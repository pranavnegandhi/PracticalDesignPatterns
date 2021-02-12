using System;
using System.Collections.Generic;
using System.Management;
using System.Threading.Tasks;

namespace Adapter
{
    public class DiskInfoProvider
    {
        public Task<IEnumerable<PropertyDataCollection>> CollectAsync()
        {
            var tcs = new TaskCompletionSource<IEnumerable<PropertyDataCollection>>();
            var watcher = new ManagementOperationObserver();
            var results = new List<PropertyDataCollection>();

            var readyHandler = new ObjectReadyEventHandler((sender, e) =>
            {
                results.Add(e.NewObject.Properties);
            });

            // The event handler that gets invoked by the watcher.
            var completedHandler = default(CompletedEventHandler);
            completedHandler = new CompletedEventHandler((sender, e) =>
            {
                var tcsLocal = tcs;
                try
                {
                    if (e.Status == ManagementStatus.NoError)
                    {
                        // The operation was completed without any errors.
                        tcsLocal.SetResult(results);
                        return;
                    }

                    if (e.Status == ManagementStatus.CallCanceled || e.Status == ManagementStatus.OperationCanceled)
                    {
                        // The task was cancelled before it could be completed.
                        tcsLocal.SetCanceled();
                        return;
                    }

                    // An exception occurred during the operation.
                    tcsLocal.SetException(new Exception($"Runtime error {e.Status}"));
                    return;
                }
                finally
                {
                    // Clean up the event handlers.
                    watcher.Completed -= completedHandler;
                }
            });

            // Wire up the event handler and begin the operation.
            watcher.ObjectReady += readyHandler;
            watcher.Completed += completedHandler;
            var management = new ManagementClass("Win32_LogicalDisk");
            management.GetInstances(watcher);

            return tcs.Task;
        }
    }
}
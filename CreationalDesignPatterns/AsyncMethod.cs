using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    class AsyncMethod
    {
        private AsyncMethod()
        {
            //
        }

        private async Task<AsyncMethod> InitAsync()
        {
            await Task.Delay(5000);
            return this;
        }

        public static Task<AsyncMethod> CreateAsync()
        {
            var task = new AsyncMethod();
            return task.InitAsync();
        }
    }
}

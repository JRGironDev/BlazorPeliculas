using BlazorMovies.Client.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Pages

{
    public partial class Counter
    {
        private int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}

using Microsoft.AspNetCore.Components;




namespace FirstBlazorAppServer.Pages
{
    public partial class Counter
    {

        private int currentCount = 0;

        [Parameter]
        public int Value { get => currentCount; set => currentCount = value; }

        private void IncrementCount()
        {
            currentCount++;
        }

    }

}

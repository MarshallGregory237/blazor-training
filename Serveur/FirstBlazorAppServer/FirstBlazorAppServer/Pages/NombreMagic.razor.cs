

using Microsoft.AspNetCore.Components;


namespace FirstBlazorAppServer.Pages
{
    public class NombreMagicBase: ComponentBase
    {

        protected const int NbLifeMax = 5;
        
        protected const int NbMax = 20;

        protected int value;


        protected  int NbMagic = 20;

        protected  int NbRemainingLife;

        protected bool? gameWon;


        protected override void OnInitialized()
        {
            
            ReinitGame();
            base.OnInitialized();
        
        }

        public void ReinitGame()
        {
            var random = new Random();

            // faire un random non negatif qui varie entre 0 et le nombre max
            NbMagic = random.Next(NbMax);

            NbRemainingLife = NbLifeMax;

            gameWon = null;

            value = 0;

        }



        protected void TestNumber()
        {

            if (value == NbMagic)
            {
                gameWon = true;
            }

            else
            {

                NbRemainingLife--;

                if (NbRemainingLife == 0)
                {
                    gameWon = false;
                }

            }

        }

       
    }

}

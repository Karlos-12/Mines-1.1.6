namespace Mines_1._0._1
{
    internal class Mines
    {
        public bool IsaMine { get; }
        public int MinesNear { get; set; }
        public string cordinates { get; }

        public Mines(bool mine, int near)
        {
            this.IsaMine = mine;
            this.MinesNear = near;


        }
        public void click( int mn)
        {
            if (this.IsaMine == true)
            {
                //explode
            }
            else
            {

            }
            
            
        }
        


    }

}

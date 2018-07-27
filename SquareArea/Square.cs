namespace SquareArea
{
    class Square
    {
        private int area;
        private int length;

        public Square (int length)
        {
            this.length = length;
            SquareArea();
        }
        private void SquareArea()
        {
            area = length * length;           
        }
        public int GetSide
        {
            get
            {
                return length;
            }           
        }
        public int GetArea
        {
            get
            {
                return area;
            }
        }


    }
}

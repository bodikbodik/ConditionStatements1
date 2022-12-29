namespace ConditionStatements1
{
    public static class Tasks
    {
        public static int Task1(int a)
        {
            if (a > 0)
            {
                return a + 1;
            }
            else
            {

                return a;
            }
        }
        
        public static int Task2(int a)
        {
            if (a > 0)
            {
                return a + 1;
            }
            else 
            {

                return a -2;
            }
        }

        public static int Task3(int a)
        {

            if (a > 0)
            {
                return a + 1;
            }
            else
            {
                if (a < 0)

                    return a - 2;
            
                else
            {
                    a = 3;
                return a;
            }

            }


                
        }
    }
}


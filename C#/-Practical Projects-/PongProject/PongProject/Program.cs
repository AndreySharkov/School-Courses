namespace PongProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field(51, 15);
            Racket left = new Racket(5, 1);
            Racket right = new Racket(5, field.GetCols - 2);
            Ball ball = new Ball(field.GetRows / 2, field.GetCols / 2);

            left.Draw(field);
            right.Draw(field);
            ball.Draw(field);

            Console.SetWindowSize(field.GetCols + 1, field.GetRows + 5);
            Console.CursorVisible = false;

            int leftScore = 0;
            int rightScore = 0;

            DrawScore(field, leftScore, rightScore);

            int skipBall = 2;
            while (true)
            {
                for (int i = 0; i < field.GetRows; i++)
                {
                    for (int j = 0; j < field.GetCols; j++)
                    {
                        DrawAt(i, j, field.Get(i, j).ToString());
                    }
                }
                ReadInput(field, left, right);
                skipBall--;
                if (skipBall == 0)
                {
                    int scored = CheckForGoal(field, ball);
                    if (scored != -1)
                    {
                        if (scored == 0)
                        {
                            leftScore++;
                        }
                        else
                        {
                            rightScore++;
                        }

                        DrawScore(field, leftScore, rightScore);
                        ball.Reset(field);
                        left.Reset(field);
                        right.Reset(field);
                    }
                    else
                    {
                        ball.CalculateTrajectory(field, left.Tile, right.Tile);
                    }
                    skipBall = 2;
                }

                Thread.Sleep(10);
            }
        }

        static void DrawScore(Field field, int leftScore, int rightScore)
        {
            DrawAt(field.GetRows + 1, 1, $"Player Left Score: {leftScore}");
            DrawAt(field.GetRows + 2, 1, $"Player Right Score: {rightScore}");
        }

        static void DrawAt(int x, int y, string s)
        {
            Console.SetCursorPosition(y, x);
            Console.WriteLine(s);
        }

        static void ReadInput(Field field, Racket left, Racket right)
        {
            if (!Console.KeyAvailable)
            {
                return;
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    left.MoveUp(field);
                    break;
                case ConsoleKey.S:
                    left.MoveDown(field);
                    break;
                case ConsoleKey.UpArrow:
                    right.MoveUp(field);
                    break;
                case ConsoleKey.DownArrow:
                    right.MoveDown(field);
                    break;
            }
        }

        static int CheckForGoal(Field field, Ball ball)
        {
            if (ball.Y <= 0)
            {
                return 1;
            }
            if (ball.Y >= field.GetCols - 1)
            {
                return 0;
            }
            return -1;
        }
    }
}
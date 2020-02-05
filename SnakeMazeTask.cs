namespace Mazes
{
    public static class SnakeMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                MoveToDirection(robot, width - 3, Direction.Right);
                MoveToDirection(robot, 2, Direction.Down);
                MoveToDirection(robot, width - 3, Direction.Left);
                if (robot.Finished)
                    break;
                MoveToDirection(robot, 2, Direction.Down);
            }
        }
        public static void MoveToDirection(Robot robot, int step, Direction direction)
        {
            for (int i = 0; i < step; i++)
            {
                robot.MoveTo(direction);
            }
        }
    }
}
using System;

namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            int stepCounter = 1;
            int firstStepLength = 1;
            int secondStepLength = 1;
            var firstStepDirection = Direction.Down;
            var secondStepDirection = Direction.Right;

            if (width > height)
            {
                stepCounter = height - 2;
                firstStepLength = width / stepCounter;
                firstStepDirection = Direction.Right;
                secondStepDirection = Direction.Down;
            }
            else
            {
                stepCounter = width - 2;
                firstStepLength = height / stepCounter;
            }
            while (true)
            {
                MoveToDirection(robot, firstStepLength, firstStepDirection);
                if (robot.Finished) break;
                MoveToDirection(robot, secondStepLength, secondStepDirection);
                if (robot.Finished) break;
            }
            
        }

        public static void MoveToDirection(Robot robot, int step, Direction direction)
        {
            for (int i = 1; i <= step; i++)
            {
                robot.MoveTo(direction);
            }
        }
    }
}
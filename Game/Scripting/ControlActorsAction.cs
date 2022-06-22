using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private Point direction = new Point(Constants.CELL_SIZE, 0);

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (keyboardService.IsKeyDown("w") || keyboardService.IsKeyDown("a") || keyboardService.IsKeyDown("s") || keyboardService.IsKeyDown("d"))
            {
                // left
                if (keyboardService.IsKeyDown("a"))
                {
                    direction = new Point(-Constants.CELL_SIZE, 0);
                }

                // right
                if (keyboardService.IsKeyDown("d"))
                {
                    direction = new Point(Constants.CELL_SIZE, 0);
                }

                // up
                if (keyboardService.IsKeyDown("w"))
                {
                    direction = new Point(0, -Constants.CELL_SIZE);
                }

                // down
                if (keyboardService.IsKeyDown("s"))
                {
                    direction = new Point(0, Constants.CELL_SIZE);
                }

                Snake snake = (Snake)cast.GetFirstActor("snake");
                snake.TurnHead(direction);
            }
            
            if (keyboardService.IsKeyDown("i") || keyboardService.IsKeyDown("j") || keyboardService.IsKeyDown("k") || keyboardService.IsKeyDown("l"))
            {
                // left
                if (keyboardService.IsKeyDown("j"))
                {
                    direction = new Point(-Constants.CELL_SIZE, 0);
                }

                // right
                if (keyboardService.IsKeyDown("l"))
                {
                    direction = new Point(Constants.CELL_SIZE, 0);
                }

                // up
                if (keyboardService.IsKeyDown("i"))
                {
                    direction = new Point(0, -Constants.CELL_SIZE);
                }

                // down
                if (keyboardService.IsKeyDown("k"))
                {
                    direction = new Point(0, Constants.CELL_SIZE);
                }

                Snake snake2 = (Snake)cast.GetFirstActor("snake2");
                snake2.TurnHead(direction);
            }
        }
        
    }
}
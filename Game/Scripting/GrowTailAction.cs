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
    public class GrowTailAction : Action
    {
     

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public GrowTailAction()
        {
            
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Snake snake = (Snake) cast.GetFirstActor("snake");  
            Snake snake2 = (Snake) cast.GetFirstActor("snake2") ;

            snake.GrowTail(1);
            snake2.GrowTail(1);
            
        }
    }
        
}

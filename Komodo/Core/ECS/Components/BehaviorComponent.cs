using GameTime = Microsoft.Xna.Framework.GameTime;

namespace Komodo.Core.ECS.Components
{
    /// <summary>
    /// Abstract class defining all behaviors.
    /// A class derived from BehaviorComponent is the main way scripting is achieved in Komodo.
    /// </summary>
    public abstract class BehaviorComponent : Component
    {
        #region Public

        #region Constructors
        public BehaviorComponent() : base(true, null)
        {
        }
        #endregion

        #region Member Methods
        /// <summary>
        /// Virtual method initializing a BehaviorComponent.
        /// </summary>
        public virtual void Initialize()
        {
            if (!IsInitialized)
            {
                IsInitialized = true;
            }
        }

        /// <summary>
        /// Abstract method for updating a BehaviorComponent.
        /// </summary>
        /// <param name="gameTime">Time passed since last <see cref="Update"/></param>
        public abstract void Update(GameTime gameTime);
        #endregion

        #endregion
    }
}
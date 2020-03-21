using System.Text.Json.Serialization;
using Komodo.Core.ECS.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Komodo.Core.ECS.Components
{
    public abstract class Component : ISerializable<Component>
    {
        #region Constructors
        protected Component(bool isEnabled = true, Entity parent = null)
        {
            IsEnabled = isEnabled;
            Parent = parent;
        }
        #endregion

        #region Members

        #region Public Members
        public bool IsEnabled { get; set; }
        public bool IsInitialized { get; private set; }
        [JsonIgnore]
        public Entity Parent { get; set; }
        public KomodoVector3 Position { get; set; }
        public KomodoVector3 WorldPosition
        {
            get
            {
                return Parent?.Position != null ? KomodoVector3.Add(Parent.Position, Position) : Position;
            }
        }
        public KomodoVector3 Rotation
        {
            get
            {
                return Parent?.Rotation != null ? Parent.Rotation : KomodoVector3.Zero;
            }
            set
            {
                if (Parent != null)
                {
                    Parent.Rotation = value;
                }
            }
        }
        public Matrix RotationMatrix
        {
            get
            {
                return Parent?.RotationMatrix != null ? Parent.RotationMatrix : Matrix.CreateFromYawPitchRoll(0f, 0f, 0f);
            }
        }
        public Quaternion RotationQuaternion
        {
            get
            {
                return Parent?.RotationQuaternion != null ? Parent.RotationQuaternion : Quaternion.CreateFromYawPitchRoll(0f, 0f, 0f);
            }
        }
        public KomodoVector3 Scale
        {
            get
            {
                return Parent?.Scale != null ? Parent.Scale : KomodoVector3.Zero;
            }
            set
            {
                if (Parent != null)
                {
                    Parent.Scale = value;
                }
            }
        }
        #endregion Public Members

        #endregion Members

        #region Member Methods

        #region Public Member Methods
        public abstract void Deserialize(SerializedObject serializedObject);
        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
        public virtual void Draw()
        {
        }
        public virtual void Initialize()
        {
            if (!IsInitialized)
            {
                IsInitialized = true;
            }
        }
        public abstract SerializedObject Serialize();
        public virtual void Update(GameTime gameTime)
        {
            
        }
        #endregion Public Member Methods
        
        #endregion Member Methods
    }
}

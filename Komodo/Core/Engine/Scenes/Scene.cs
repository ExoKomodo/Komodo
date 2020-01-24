using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Komodo.Core.Engine.Entities;
using System.Text.Json.Serialization;

namespace Komodo.Core.Engine.Scenes
{
    public class Scene : IScene
    {
        #region Constructors
        public Scene()
        {
            Entities = new List<IEntity>();
        }
        #endregion Constructors

        #region Members

        #region Public Members
        public List<IEntity> Entities
        {
            get
            {
                return _entities;
            }
            set
            {
                _entities = value;
            }
        }
        [JsonIgnore]
        public IScene Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }
        #endregion Public Members

        #region Protected Members
        protected List<IEntity> _entities;
        protected IScene _parent;
        #endregion Protected Members

        #region Private Members
        #endregion Private Members

        #endregion Members

        #region Member Methods

        #region Public Member Methods
        public void AddEntity(IEntity entityToAdd)
        {
            if (Entities == null)
            {
                Entities = new List<IEntity>();
            }
            if (entityToAdd.ParentScene != null)
            {
                entityToAdd.ParentScene.RemoveEntity(entityToAdd);
            }
            Entities.Add(entityToAdd);
            entityToAdd.ParentScene = this;
        }

        public void ClearEntities()
        {
            if (Entities != null)
            {
                foreach (var entity in Entities)
                {
                    entity.ParentScene = null;
                }
                Entities.Clear();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Entities != null)
            {
                foreach (var entity in Entities)
                {
                    entity.Draw(spriteBatch);
                }
            }
        }

        public bool RemoveEntity(IEntity entityToRemove)
        {
            if (Entities != null)
            {
                entityToRemove.ParentScene = null;
                return Entities.Remove(entityToRemove);
            }
            return false;
        }


        public void Update(GameTime gameTime)
        {
            if (Entities != null)
            {
                foreach (var entity in Entities)
                {
                    entity.Update(gameTime);
                }
            }
        }
        #endregion Public Member Methods

        #region Protected Member Methods
        #endregion Protected Member Methods

        #region Private Member Methods
        #endregion Private Member Methods

        #endregion Member Methods
    }
}
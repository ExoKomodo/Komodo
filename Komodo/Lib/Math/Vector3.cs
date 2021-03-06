using System;

using Matrix = Microsoft.Xna.Framework.Matrix;
using Quaternion = Microsoft.Xna.Framework.Quaternion;
using MonoGameVector3 = Microsoft.Xna.Framework.Vector3;

namespace Komodo.Lib.Math
{
    public readonly struct Vector3 : IEquatable<Vector3>
    {
        #region Public

        #region Constructors
        public Vector3(MonoGameVector3 vector) : this(vector.X, vector.Y, vector.Z)
        {
        }

        public Vector3(Vector3 vector) : this(vector.X, vector.Y, vector.Z)
        {
        }

        public Vector3(float x = 0f, float y = 0f, float z = 0f)
        {
            MonoGameVector = new MonoGameVector3(x, y, z);
        }
        #endregion

        #region Public Members
        public MonoGameVector3 MonoGameVector { get; }
        public float X
        {
            get
            {
                return MonoGameVector.X;
            }
        }

        public float Y
        {
            get
            {
                return MonoGameVector.Y;
            }
        }

        public float Z
        {
            get
            {
                return MonoGameVector.Z;
            }
        }

        #region Swizzling
        public Vector2 XY
        {
            get
            {
                return new Vector2(X, Y);
            }
        }

        public Vector2 XZ
        {
            get
            {
                return new Vector2(X, Z);
            }
        }

        public Vector2 YX
        {
            get
            {
                return new Vector2(Y, X);
            }
        }

        public Vector2 YZ
        {
            get
            {
                return new Vector2(Y, Z);
            }
        }

        public Vector2 ZX
        {
            get
            {
                return new Vector2(Z, X);
            }
        }

        public Vector2 ZY
        {
            get
            {
                return new Vector2(Z, Y);
            }
        }

        public Vector3 XYZ
        {
            get
            {
                return new Vector3(X, Y, Z);
            }
        }

        public Vector3 XZY
        {
            get
            {
                return new Vector3(X, Z, Y);
            }
        }

        public Vector3 YXZ
        {
            get
            {
                return new Vector3(Y, X, Z);
            }
        }

        public Vector3 YZX
        {
            get
            {
                return new Vector3(Y, Z, X);
            }
        }

        public Vector3 ZXY
        {
            get
            {
                return new Vector3(Z, X, Y);
            }
        }

        public Vector3 ZYX
        {
            get
            {
                return new Vector3(Z, Y, X);
            }
        }
        #endregion

        #endregion

        #region Member Methods
        public override bool Equals(object obj)
        {
            if (obj is Vector3 other)
            {
                return Equals(other);
            }
            return false;
        }
        public bool Equals(Vector3 other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode();
        }

        public float Length()
        {
            return MonoGameVector.Length();
        }
        #endregion

        #region Static Members
        public static Vector3 One => new Vector3(1f, 1f, 1f);
        public static Vector3 Zero => new Vector3();
        public static Vector3 Up => new Vector3(0f, 1f, 0f);
        public static Vector3 Down => -Up;
        public static Vector3 Right => new Vector3(1f, 0f, 0f);
        public static Vector3 Left => -Right;
        public static Vector3 Back => new Vector3(0f, 0f, 1f);
        public static Vector3 Forward => -Back;
        public static Vector3 Max(Vector3 left, Vector3 right)
        {
            return new Vector3(MonoGameVector3.Max(left.MonoGameVector, right.MonoGameVector));
        }
        public static Vector3 Min(Vector3 left, Vector3 right)
        {
            return new Vector3(MonoGameVector3.Min(left.MonoGameVector, right.MonoGameVector));
        }
        #endregion

        #region Static Methods
        public static Vector3 operator +(Vector3 vector) => vector;
        public static Vector3 operator -(Vector3 vector) => new Vector3(-vector.X, -vector.Y, -vector.Z);

        public static Vector3 Add(Vector3 left, Vector3 right)
        {
            var result = MonoGameVector3.Add(left.MonoGameVector, right.MonoGameVector);
            return new Vector3(result);
        }
        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return Add(left, right);
        }

        public static Vector3 Divide(Vector3 vector, float scale)
        {
            var result = MonoGameVector3.Divide(vector.MonoGameVector, scale);
            return new Vector3(result);
        }
        public static Vector3 operator /(Vector3 left, float scale)
        {
            return Divide(left, scale);
        }

        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !(left == right);
        }

        public static Vector3 Multiply(Vector3 left, float scale)
        {
            var result = MonoGameVector3.Multiply(left.MonoGameVector, scale);
            return new Vector3(result);
        }
        public static Vector3 operator *(Vector3 left, float scale)
        {
            return Multiply(left, scale);
        }

        public static Vector3 Multiply(Vector3 left, Vector3 right)
        {
            var result = MonoGameVector3.Multiply(left.MonoGameVector, right.MonoGameVector);
            return new Vector3(result);
        }
        public static Vector3 operator *(Vector3 left, Vector3 right)
        {
            return Multiply(left, right);
        }

        public static Vector3 Subtract(Vector3 left, Vector3 right)
        {
            var result = MonoGameVector3.Subtract(left.MonoGameVector, right.MonoGameVector);
            return new Vector3(result);
        }
        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return Subtract(left, right);
        }

        public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)
        {
            var result = MonoGameVector3.Clamp(value.MonoGameVector, min.MonoGameVector, max.MonoGameVector);
            return new Vector3(result);
        }

        public static Vector3 Normalize(Vector3 vectorToNormalize)
        {
            var normalizedVector = MonoGameVector3.Normalize(vectorToNormalize.MonoGameVector);
            return new Vector3(normalizedVector);
        }

        public static Vector3 Transform(Vector3 vector, Matrix transform)
        {
            return new Vector3(
                MonoGameVector3.Transform(vector.MonoGameVector, transform)
            );
        }

        public static Vector3 Transform(Vector3 vector, Quaternion transform)
        {
            return new Vector3(
                MonoGameVector3.Transform(vector.MonoGameVector, transform)
            );
        }

        public static Vector3 Cross(Vector3 a, Vector3 b)
        {
            return new Vector3(MonoGameVector3.Cross(a.MonoGameVector, b.MonoGameVector));
        }

        public static float Dot(Vector3 a, Vector3 b)
        {
            return MonoGameVector3.Dot(a.MonoGameVector, b.MonoGameVector);
        }

        public static float Distance(Vector3 a, Vector3 b)
        {
            return MonoGameVector3.Distance(a.MonoGameVector, b.MonoGameVector);
        }

        public static float DistanceSquared(Vector3 a, Vector3 b)
        {
            return MonoGameVector3.DistanceSquared(a.MonoGameVector, b.MonoGameVector);
        }

        /// <summary>
        /// Returns the reflection of a vector over a given normal.
        /// </summary>
        /// <param name="vectorToReflect">Vector to reflect over the normal.</param>
        /// <param name="normal">Normal to reflect the vector over.</param>
        /// <returns>Reflected vector over the the normal.</returns>
        public static Vector3 Reflect(Vector3 vectorToReflect, Vector3 normal)
        {
            var reflection = MonoGameVector3.Reflect(vectorToReflect.MonoGameVector, normal.MonoGameVector);
            return new Vector3(reflection);
        }
        #endregion

        #endregion
    }
}
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Buttons = Microsoft.Xna.Framework.Input.Buttons;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
using Keys = Microsoft.Xna.Framework.Input.Keys;
using KeyState = Microsoft.Xna.Framework.Input.KeyState;

namespace Komodo.Core.Engine.Input
{
    /// <summary>
    /// Static class for mapping <see cref="Komodo.Core.Engine.Input.Inputs"/> and MonoGame input identifiers to and from one another.
    /// </summary>
    internal static class InputMapper
    {
        #region Internal

        #region Static Methods
        /// <summary>
        /// Converts <see cref="Microsoft.Xna.Framework.Input.Buttons"/> to <see cref="Komodo.Core.Engine.Input.Inputs"/>.
        /// </summary>
        /// <param name="button">MonoGame button.</param>
        /// <returns>Converted MonoGame button.</returns>
        internal static Inputs ToInputs(Buttons button)
        {
            return button switch
            {
                Buttons.A => Inputs.ButtonA,
                Buttons.B => Inputs.ButtonB,
                Buttons.DPadDown => Inputs.ButtonDown,
                Buttons.BigButton => Inputs.ButtonHome,
                Buttons.LeftShoulder => Inputs.ButtonL1,
                Buttons.LeftTrigger => Inputs.ButtonL2,
                Buttons.LeftStick => Inputs.ButtonL3,
                Buttons.DPadLeft => Inputs.ButtonLeft,
                Buttons.RightShoulder => Inputs.ButtonR1,
                Buttons.RightTrigger => Inputs.ButtonR2,
                Buttons.RightStick => Inputs.ButtonR3,
                Buttons.DPadRight => Inputs.ButtonRight,
                Buttons.Back => Inputs.ButtonSelect,
                Buttons.Start => Inputs.ButtonStart,
                Buttons.DPadUp => Inputs.ButtonUp,
                Buttons.X => Inputs.ButtonX,
                Buttons.Y => Inputs.ButtonY,
                _ => Inputs.Undefined,
            };
        }

        /// <summary>
        /// Converts <see cref="Microsoft.Xna.Framework.Input.Keys"/> to <see cref="Komodo.Core.Engine.Input.Inputs"/>.
        /// </summary>
        /// <param name="key">MonoGame key.</param>
        /// <returns>Converted MonoGame key.</returns>
        internal static Inputs ToInputs(Keys key)
        {
            return key switch
            {
                Keys.A => Inputs.KeyA,
                Keys.Add => Inputs.KeyAdd,
                Keys.B => Inputs.KeyB,
                Keys.Back => Inputs.KeyBackSpace,
                Keys.C => Inputs.KeyC,
                Keys.CapsLock => Inputs.KeyCapsLock,
                Keys.D => Inputs.KeyD,
                Keys.D0 => Inputs.Key0,
                Keys.D1 => Inputs.Key1,
                Keys.D2 => Inputs.Key2,
                Keys.D3 => Inputs.Key3,
                Keys.D4 => Inputs.Key4,
                Keys.D5 => Inputs.Key5,
                Keys.D6 => Inputs.Key6,
                Keys.D7 => Inputs.Key7,
                Keys.D8 => Inputs.Key8,
                Keys.D9 => Inputs.Key9,
                Keys.Decimal => Inputs.KeyDecimal,
                Keys.Delete => Inputs.KeyDelete,
                Keys.Divide => Inputs.KeyDivide,
                Keys.Down => Inputs.KeyDown,
                Keys.E => Inputs.KeyE,
                Keys.Enter => Inputs.KeyEnter,
                Keys.Escape => Inputs.KeyEscape,
                Keys.F => Inputs.KeyF,
                Keys.F1 => Inputs.KeyF1,
                Keys.F10 => Inputs.KeyF10,
                Keys.F11 => Inputs.KeyF11,
                Keys.F12 => Inputs.KeyF12,
                Keys.F2 => Inputs.KeyF2,
                Keys.F3 => Inputs.KeyF3,
                Keys.F4 => Inputs.KeyF4,
                Keys.F5 => Inputs.KeyF5,
                Keys.F6 => Inputs.KeyF6,
                Keys.F7 => Inputs.KeyF7,
                Keys.F8 => Inputs.KeyF8,
                Keys.F9 => Inputs.KeyF9,
                Keys.G => Inputs.KeyG,
                Keys.H => Inputs.KeyH,
                Keys.I => Inputs.KeyI,
                Keys.J => Inputs.KeyJ,
                Keys.K => Inputs.KeyK,
                Keys.L => Inputs.KeyL,
                Keys.Left => Inputs.KeyLeft,
                Keys.LeftAlt => Inputs.KeyLeftAlt,
                Keys.LeftControl => Inputs.KeyLeftControl,
                Keys.LeftShift => Inputs.KeyLeftShift,
                Keys.M => Inputs.KeyM,
                Keys.Multiply => Inputs.KeyMultiply,
                Keys.N => Inputs.KeyN,
                Keys.NumPad0 => Inputs.KeyNumPad0,
                Keys.NumPad1 => Inputs.KeyNumPad1,
                Keys.NumPad2 => Inputs.KeyNumPad2,
                Keys.NumPad3 => Inputs.KeyNumPad3,
                Keys.NumPad4 => Inputs.KeyNumPad4,
                Keys.NumPad5 => Inputs.KeyNumPad5,
                Keys.NumPad6 => Inputs.KeyNumPad6,
                Keys.NumPad7 => Inputs.KeyNumPad7,
                Keys.NumPad8 => Inputs.KeyNumPad8,
                Keys.NumPad9 => Inputs.KeyNumPad9,
                Keys.O => Inputs.KeyO,
                Keys.OemBackslash => Inputs.KeyBackslash,
                Keys.OemCloseBrackets => Inputs.KeyCloseBrackets,
                Keys.OemComma => Inputs.KeyComma,
                Keys.OemMinus => Inputs.KeyMinus,
                Keys.OemOpenBrackets => Inputs.KeyOpenBrackets,
                Keys.OemPeriod => Inputs.KeyPeriod,
                Keys.OemPipe => Inputs.KeyBackslash,
                Keys.OemPlus => Inputs.KeyPlus,
                Keys.OemQuestion => Inputs.KeyQuestion,
                Keys.OemQuotes => Inputs.KeyQuotes,
                Keys.OemSemicolon => Inputs.KeySemicolon,
                Keys.OemTilde => Inputs.KeyTilde,
                Keys.P => Inputs.KeyP,
                Keys.Q => Inputs.KeyQ,
                Keys.R => Inputs.KeyR,
                Keys.Right => Inputs.KeyRight,
                Keys.RightAlt => Inputs.KeyRightAlt,
                Keys.RightControl => Inputs.KeyRightControl,
                Keys.RightShift => Inputs.KeyRightShift,
                Keys.S => Inputs.KeyS,
                Keys.Space => Inputs.KeySpace,
                Keys.Subtract => Inputs.KeySubtract,
                Keys.T => Inputs.KeyT,
                Keys.Tab => Inputs.KeyTab,
                Keys.U => Inputs.KeyU,
                Keys.Up => Inputs.KeyUp,
                Keys.V => Inputs.KeyV,
                Keys.W => Inputs.KeyW,
                Keys.X => Inputs.KeyX,
                Keys.Y => Inputs.KeyY,
                Keys.Z => Inputs.KeyZ,
                _ => Inputs.Undefined,
            };
        }

        /// <summary>
        /// Converts <see cref="Microsoft.Xna.Framework.Input.ButtonState"/> to <see cref="Komodo.Core.Engine.Input.InputState"/>.
        /// </summary>
        /// <param name="buttonState">MonoGame button state.</param>
        /// <returns>Converted MonoGame button state.</returns>
        internal static InputState ToInputState(ButtonState buttonState)
        {
            return buttonState switch
            {
                ButtonState.Released => InputState.Up,
                ButtonState.Pressed => InputState.Down,
                _ => InputState.Undefined,
            };
        }

        /// <summary>
        /// Converts <see cref="Microsoft.Xna.Framework.Input.KeyState"/> to <see cref="Komodo.Core.Engine.Input.InputState"/>.
        /// </summary>
        /// <param name="keyState">MonoGame key state.</param>
        /// <returns>Converted MonoGame key state.</returns>
        internal static InputState ToInputState(KeyState keyState)
        {
            return keyState switch
            {
                KeyState.Up => InputState.Up,
                KeyState.Down => InputState.Down,
                _ => InputState.Undefined,
            };
        }

        /// <summary>
        /// Converts <see cref="Komodo.Core.Engine.Input.Inputs"/> to <see cref="Microsoft.Xna.Framework.Input.Buttons"/>.
        /// </summary>
        /// <param name="input">Komodo input.</param>
        /// <returns>Converted Komodo input as <see cref="Microsoft.Xna.Framework.Input.Buttons"/>.</returns>
        internal static Buttons? ToMonoGameButton(Inputs input)
        {
            return input switch
            {
                Inputs.ButtonA => Buttons.A,
                Inputs.ButtonB => Buttons.B,
                Inputs.ButtonDown => Buttons.DPadDown,
                Inputs.ButtonHome => Buttons.BigButton,
                Inputs.ButtonL1 => Buttons.LeftShoulder,
                Inputs.ButtonL2 => Buttons.LeftTrigger,
                Inputs.ButtonL3 => Buttons.LeftStick,
                Inputs.ButtonLeft => Buttons.DPadLeft,
                Inputs.ButtonR1 => Buttons.RightShoulder,
                Inputs.ButtonR2 => Buttons.RightTrigger,
                Inputs.ButtonR3 => Buttons.RightStick,
                Inputs.ButtonRight => Buttons.DPadRight,
                Inputs.ButtonSelect => Buttons.Back,
                Inputs.ButtonStart => Buttons.Start,
                Inputs.ButtonUp => Buttons.DPadUp,
                Inputs.ButtonX => Buttons.X,
                Inputs.ButtonY => Buttons.Y,
                _ => null,
            };
        }

        /// <summary>
        /// Converts <see cref="Komodo.Core.Engine.Input.Inputs"/> to <see cref="Microsoft.Xna.Framework.Input.Keys"/>.
        /// </summary>
        /// <param name="input">Komodo input.</param>
        /// <returns>Converted Komodo input as <see cref="Microsoft.Xna.Framework.Input.Keys"/>.</returns>
        internal static Keys ToMonoGameKey(Inputs input)
        {
            var result = input switch
            {
                Inputs.Key0 => Keys.D0,
                Inputs.Key1 => Keys.D1,
                Inputs.Key2 => Keys.D2,
                Inputs.Key3 => Keys.D3,
                Inputs.Key4 => Keys.D4,
                Inputs.Key5 => Keys.D5,
                Inputs.Key6 => Keys.D6,
                Inputs.Key7 => Keys.D7,
                Inputs.Key8 => Keys.D8,
                Inputs.Key9 => Keys.D9,
                Inputs.KeyA => Keys.A,
                Inputs.KeyAdd => Keys.Add,
                Inputs.KeyB => Keys.B,
                Inputs.KeyBackSpace => Keys.Back,
                Inputs.KeyBackslash => Keys.OemPipe,
                Inputs.KeyC => Keys.C,
                Inputs.KeyCapsLock => Keys.CapsLock,
                Inputs.KeyCloseBrackets => Keys.OemCloseBrackets,
                Inputs.KeyComma => Keys.OemComma,
                Inputs.KeyD => Keys.D,
                Inputs.KeyDecimal => Keys.Decimal,
                Inputs.KeyDelete => Keys.Delete,
                Inputs.KeyDivide => Keys.Divide,
                Inputs.KeyDown => Keys.Down,
                Inputs.KeyE => Keys.E,
                Inputs.KeyEnter => Keys.Enter,
                Inputs.KeyEscape => Keys.Escape,
                Inputs.KeyF => Keys.F,
                Inputs.KeyF1 => Keys.F1,
                Inputs.KeyF10 => Keys.F10,
                Inputs.KeyF11 => Keys.F11,
                Inputs.KeyF12 => Keys.F12,
                Inputs.KeyF2 => Keys.F2,
                Inputs.KeyF3 => Keys.F3,
                Inputs.KeyF4 => Keys.F4,
                Inputs.KeyF5 => Keys.F5,
                Inputs.KeyF6 => Keys.F6,
                Inputs.KeyF7 => Keys.F7,
                Inputs.KeyF8 => Keys.F8,
                Inputs.KeyF9 => Keys.F9,
                Inputs.KeyG => Keys.G,
                Inputs.KeyH => Keys.H,
                Inputs.KeyI => Keys.I,
                Inputs.KeyJ => Keys.J,
                Inputs.KeyK => Keys.K,
                Inputs.KeyL => Keys.L,
                Inputs.KeyLeft => Keys.Left,
                Inputs.KeyLeftAlt => Keys.LeftAlt,
                Inputs.KeyLeftControl => Keys.LeftControl,
                Inputs.KeyLeftShift => Keys.LeftShift,
                Inputs.KeyM => Keys.M,
                Inputs.KeyMinus => Keys.OemMinus,
                Inputs.KeyMultiply => Keys.Multiply,
                Inputs.KeyN => Keys.N,
                Inputs.KeyNumPad0 => Keys.NumPad0,
                Inputs.KeyNumPad1 => Keys.NumPad1,
                Inputs.KeyNumPad2 => Keys.NumPad2,
                Inputs.KeyNumPad3 => Keys.NumPad3,
                Inputs.KeyNumPad4 => Keys.NumPad4,
                Inputs.KeyNumPad5 => Keys.NumPad5,
                Inputs.KeyNumPad6 => Keys.NumPad6,
                Inputs.KeyNumPad7 => Keys.NumPad7,
                Inputs.KeyNumPad8 => Keys.NumPad8,
                Inputs.KeyNumPad9 => Keys.NumPad9,
                Inputs.KeyO => Keys.O,
                Inputs.KeyOpenBrackets => Keys.OemOpenBrackets,
                Inputs.KeyP => Keys.P,
                Inputs.KeyPeriod => Keys.OemPeriod,
                Inputs.KeyPlus => Keys.OemPlus,
                Inputs.KeyQ => Keys.Q,
                Inputs.KeyQuestion => Keys.OemQuestion,
                Inputs.KeyQuotes => Keys.OemQuotes,
                Inputs.KeyR => Keys.R,
                Inputs.KeyRight => Keys.Right,
                Inputs.KeyRightAlt => Keys.RightAlt,
                Inputs.KeyRightControl => Keys.RightControl,
                Inputs.KeyRightShift => Keys.RightShift,
                Inputs.KeyS => Keys.S,
                Inputs.KeySemicolon => Keys.OemSemicolon,
                Inputs.KeySpace => Keys.Space,
                Inputs.KeySubtract => Keys.Subtract,
                Inputs.KeyT => Keys.T,
                Inputs.KeyTab => Keys.Tab,
                Inputs.KeyTilde => Keys.OemTilde,
                Inputs.KeyU => Keys.U,
                Inputs.KeyUp => Keys.Up,
                Inputs.KeyV => Keys.V,
                Inputs.KeyW => Keys.W,
                Inputs.KeyX => Keys.X,
                Inputs.KeyY => Keys.Y,
                Inputs.KeyZ => Keys.Z,
                _ => Keys.None,
            };
            return result;
        }
        #endregion

        #endregion
    }
}
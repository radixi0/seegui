﻿using System;

namespace SeeGui
{
    public class ScreenInfo
    {
        /// <summary>
        /// Default constructor
        /// Retrieves all available console information
        /// </summary>
        public ScreenInfo()
        {
            // Screen dimensions
            Width = Console.WindowWidth;
            Height = Console.WindowHeight;
            MaxWidth = Console.LargestWindowWidth;
            MaxHeight = Console.LargestWindowHeight;

            // Buffers
            BufferWidth = Console.BufferWidth;
            BufferHeight = Console.BufferHeight;

            // Keys Status
            // TODO Linux
            if (SeeGui.IsWindowsOS())
            {
                CapsLock = Console.CapsLock;
                NumLock = Console.NumberLock;
            }
        }

        /// <summary>
        /// The current height, in rows, of the buffer area.
        /// </summary>
        public int BufferHeight { get; }

        /// <summary>
        /// Get the width of the buffer area
        /// </summary>
        public int BufferWidth { get; }

        /// <summary>
        /// Return true if CAPS LOCK is on
        /// </summary>
        public bool CapsLock { get; }

        /// <summary>
        /// Get the height of the console window
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets the largest possible number of console window rows,
        /// based on the current font and screen resolution.
        /// </summary>
        public int MaxHeight { get; }

        /// <summary>
        /// Gets the largest possible number of console window columns,
        /// based on the current font and screen resolution.
        /// </summary>
        public int MaxWidth { get; }

        /// <summary>
        /// Return true if NUNLOCK is on
        /// </summary>
        public bool NumLock { get; }

        /// <summary>
        /// Get the width of the console window
        /// </summary>
        public int Width { get; }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace BinaryScreenDump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            palettes.Add(palette1);
            palettes.Add(palette2);
            palettes.Add(palette3);
            palettes.Add(palette3a);
            palettes.Add(palette4);
            palettes.Add(palette5);
            palettes.Add(palette6);
            palettes.Add(palette7);
            palettes.Add(palette8);
            palettes.Add(palette9);
            palettes.Add(palette10);
            palettes.Add(palette11);
            palettes.Add(palette12);
            palettes.Add(palette13);
            palettes.Add(palette14);
            palettes.Add(palette15);
            palettes.Add(palette16);
            palettes.Add(palette17);
            palettes.Add(palette18);
            palettes.Add(palette19);
            palettes.Add(palette20);
            palettes.Add(palette21);
            palettes.Add(palette22);
            palettes.Add(palette23);
            palettes.Add(palette24);
            palettes.Add(palette25);
            palettes.Add(palette26);

            InitializeComponent();
        }

        public byte[] data = null;
        public int bitspetpixel = 4;

        List<Color[]> palettes = new List<Color[]>();
        int currentPaletteIndex = 0;

        // pac man
        Color[] palette1 = new Color[16] { Color.FromArgb(0x2b, 0x21, 0x18),
                                           Color.FromArgb(0xa8, 0xa8, 0xa8),
                                           Color.FromArgb(0xa8, 0xa8, 0x5b),
                                           Color.FromArgb(0xa8, 0xa8, 0x3e),
                                           Color.FromArgb(0xa8, 0xa8, 0x2b),
                                           Color.FromArgb(0xa8, 0xa8, 0x21),
                                           Color.FromArgb(0xa8, 0xa8, 0x18),
                                           Color.FromArgb(0xa8, 0x94, 0x21),
                                           Color.FromArgb(0x9e, 0x8b, 0x21),
                                           Color.FromArgb(0x94, 0x81, 0x21),
                                           Color.FromArgb(0x8b, 0x78, 0x21),
                                           Color.FromArgb(0x81, 0x6e, 0x21),
                                           Color.FromArgb(0x78, 0x64, 0x21),
                                           Color.FromArgb(0x6e, 0x5b, 0x21),
                                           Color.FromArgb(0x64, 0x51, 0x21),
                                           Color.FromArgb(0xff, 0xff, 0xff) };

        // power pill
        Color[] palette2 = new Color[16] { Color.FromArgb(0x00, 0x00, 0x00),
                                           Color.FromArgb(0xb1, 0xb1, 0xb1),
                                           Color.FromArgb(0xb1, 0xae, 0xa3),
                                           Color.FromArgb(0xb1, 0xac, 0x95),
                                           Color.FromArgb(0xb1, 0xaa, 0x88),
                                           Color.FromArgb(0xb1, 0xa7, 0x7a),
                                           Color.FromArgb(0xb1, 0xa5, 0x6c),
                                           Color.FromArgb(0xb1, 0x9b, 0x62),
                                           Color.FromArgb(0xb1, 0x91, 0x58),
                                           Color.FromArgb(0xb1, 0x88, 0x4e),  
                                           Color.FromArgb(0xb1, 0x7e, 0x43),
                                           Color.FromArgb(0xb1, 0x79, 0x3e),
                                           Color.FromArgb(0xb1, 0x73, 0x39),
                                           Color.FromArgb(0xb1, 0x73, 0x39),
                                           Color.FromArgb(0xff, 0xff, 0xff),
                                           Color.FromArgb(0xff, 0xff, 0xff) };

        // purple ghost sue
        Color[] palette3 = new Color[16] { Color.FromArgb(0x34, 0x34, 0x34),
                                           Color.FromArgb(0xa8, 0x94, 0xa8),
                                           Color.FromArgb(0xa8, 0x81, 0xa8),
                                           Color.FromArgb(0x9e, 0x64, 0xa8),
                                           Color.FromArgb(0x94, 0x5b, 0x9e),
                                           Color.FromArgb(0x8b, 0x51, 0x94),
                                           Color.FromArgb(0x81, 0x48, 0x8b),
                                           Color.FromArgb(0x78, 0x3e, 0x81),
                                           Color.FromArgb(0x6e, 0x34, 0x78),
                                           Color.FromArgb(0x64, 0x2b, 0x6e),
                                           Color.FromArgb(0x5b, 0x21, 0x64),
                                           Color.FromArgb(0x56, 0x21, 0x60),
                                           Color.FromArgb(0x4c, 0x21, 0x56),
                                           Color.FromArgb(0x43, 0x21, 0x4c),
                                           Color.FromArgb(0xa8, 0xa8, 0xa8),
                                           Color.FromArgb(0xff, 0xff, 0xff) };

        // sues scoring
        Color[] palette3a = new Color[16] { Color.FromArgb(0x93,0x85,0xb1),
                                           Color.FromArgb(0x27,0x1d,0x37),
                                           Color.FromArgb(0xa8, 0x81, 0xa8),
                                           Color.FromArgb(0x9e, 0x64, 0xa8),
                                           Color.FromArgb(0x94, 0x5b, 0x9e),
                                           Color.FromArgb(0x8b, 0x51, 0x94),
                                           Color.FromArgb(0x81, 0x48, 0x8b),
                                           Color.FromArgb(0x78, 0x3e, 0x81),
                                           Color.FromArgb(0x6e, 0x34, 0x78),
                                           Color.FromArgb(0x64, 0x2b, 0x6e),
                                           Color.FromArgb(0x5b, 0x21, 0x64),
                                           Color.FromArgb(0x56, 0x21, 0x60),
                                           Color.FromArgb(0x4c, 0x21, 0x56),
                                           Color.FromArgb(0x43, 0x21, 0x4c),
                                           Color.FromArgb(0xa8, 0xa8, 0xa8),
                                           Color.FromArgb(0xff, 0xff, 0xff) };

        // orange ghost clyde
        Color[] palette4 = new Color[16] { Color.FromArgb(0x34,0x34,0x34),
                                           Color.FromArgb(0xa8,0xa8,0x81),
                                           Color.FromArgb(0xa8,0x9e,0x6e),
                                           Color.FromArgb(0xa8,0x9e,0x64),
                                           Color.FromArgb(0xa8,0x94,0x5b),
                                           Color.FromArgb(0xa8,0x94,0x51),
                                           Color.FromArgb(0xa8,0x8b,0x48),
                                           Color.FromArgb(0xa8,0x81,0x3e),
                                           Color.FromArgb(0xa8,0x78,0x34),
                                           Color.FromArgb(0xa8,0x6e,0x2b),
                                           Color.FromArgb(0xa8,0x64,0x21),
                                           Color.FromArgb(0xa8,0x5b,0x21),
                                           Color.FromArgb(0xa8,0x51,0x21),
                                           Color.FromArgb(0xa8,0x64,0x21),
                                           Color.FromArgb(0xa8,0xa8,0xa8),
                                           Color.FromArgb(0xff, 0xff, 0xff) };


        



        /* spinning animation

        6  dying
7 dying
8 dying
9 dying


1 dying 2
2 dying 2
3 dying 2
4 dying 1

        */



        // Pacman smaller dying not same palette  as pacman??
        Color[] palette5 = new Color[16] { Color.FromArgb(0x5f, 0x4b, 0x22),   // 0 
                                           Color.FromArgb(0x2c, 0x22, 0x18),    // 1
                                           Color.FromArgb(0xb1, 0xb1, 0xb1),    // 2
                                           Color.FromArgb(0xb1, 0xb1, 0x5f),   // 3
                                           Color.FromArgb(0xb1, 0xb1, 0x40),  // 4
                                           Color.FromArgb(0xb1, 0xb1, 0x2c), // 5
                                           Color.FromArgb(0xb1, 0xb1, 0x22), // 6
                                           Color.FromArgb(0xb1, 0xb1, 0x18), // 7
                                           Color.FromArgb(0xb1, 0x9c, 0x22), // 8
                                           Color.FromArgb(0xa7, 0x8d, 0x22), // 9
                                           Color.FromArgb(0x9c, 0x88, 0x22), // a
                                           Color.FromArgb(0x92, 0x7e, 0x22), // b
                                           Color.FromArgb(0x88, 0x73, 0x22), // c
                                           Color.FromArgb(0x7e, 0x69, 0x22), // d
                                           Color.FromArgb(0x73, 0x5f, 0x22), // e
                                           Color.FromArgb(0xff, 0xff, 0xff) }; //f




        // frighten
        Color[] palette6 = new Color[16] { Color.FromArgb(0xff,0x00,0x00),  // not used?
                                           Color.FromArgb(0x8b,0x94,0xa8),
                                           Color.FromArgb(0x78,0x81,0xa8),
                                           Color.FromArgb(0x64,0x6e,0xa8),
                                           Color.FromArgb(0x5b,0x64,0xa8),
                                           Color.FromArgb(0x51,0x5b,0x9e),
                                           Color.FromArgb(0x48,0x51,0x94),
                                           Color.FromArgb(0x3e,0x48,0x8b),
                                           Color.FromArgb(0x34,0x3e,0x81),
                                           Color.FromArgb(0x2b,0x34,0x78),
                                           Color.FromArgb(0x21,0x2b,0x6e),
                                           Color.FromArgb(0x21,0x2b,0x64),
                                           Color.FromArgb(0x21,0x2b,0x5b),
                                           Color.FromArgb(0x21,0x2b,0x51),
                                           Color.FromArgb(0xa8,0xa8,0xa8),
                                           Color.FromArgb(0xff, 0xff, 0xff) };

        // eaten eyes
        Color[] palette7 = new Color[16] { Color.FromArgb(0xff,0x00,0x00),  // not used?
                                           Color.FromArgb(0x18,0x18,0x18),
                                           Color.FromArgb(0x21,0x21,0x21),
                                           Color.FromArgb(0x2b,0x2b,0x2b),
                                           Color.FromArgb(0x3e,0x48,0x51),
                                           Color.FromArgb(0x48,0x51,0x5b),
                                           Color.FromArgb(0x51,0x5b,0x64),
                                           Color.FromArgb(0x5b,0x64,0x6e),
                                           Color.FromArgb(0x64,0x6e,0x78),
                                           Color.FromArgb(0x6e,0x78,0x81),
                                           Color.FromArgb(0x78,0x81,0x8b),
                                           Color.FromArgb(0x81,0x8b,0x94), 
                                           Color.FromArgb(0x8b,0x94,0x9e),
                                           Color.FromArgb(0x94,0x9e,0xa8),
                                           Color.FromArgb(0xa8,0xa8,0xa8),
                                           Color.FromArgb(0xff, 0xff, 0xff) };



        // ghost scoring
        Color[] palette8 = new Color[16] { Color.FromArgb(0xff,0xff,0xff),
                                           Color.FromArgb(0x27,0x27,0x27),
                                           Color.FromArgb(0xff, 0xff, 0xff),
                                           Color.FromArgb(0x27, 0x27, 0x27),
                                           Color.FromArgb(0x94, 0x5b, 0x9e),
                                           Color.FromArgb(0x8b, 0x51, 0x94),
                                           Color.FromArgb(0x81, 0x48, 0x8b),
                                           Color.FromArgb(0x78, 0x3e, 0x81),
                                           Color.FromArgb(0x6e, 0x34, 0x78),
                                           Color.FromArgb(0x64, 0x2b, 0x6e),
                                           Color.FromArgb(0x5b, 0x21, 0x64),
                                           Color.FromArgb(0x56, 0x21, 0x60),
                                           Color.FromArgb(0x4c, 0x21, 0x56),
                                           Color.FromArgb(0x43, 0x21, 0x4c),
                                           Color.FromArgb(0xa8, 0xa8, 0xa8),
                                           Color.FromArgb(0x00, 0x00, 0x00) };


        // red pill pickup
        Color[] palette9 = new Color[16] { Color.FromArgb(0xff,0xff,0xff),
                                           Color.FromArgb(0xa8,0x9e,0x9e),
                                           Color.FromArgb(0xa8,0x8b,0x8b),
                                           Color.FromArgb(0xa8,0x81,0x81),
                                           Color.FromArgb(0xa8,0x78,0x78),
                                           Color.FromArgb(0xa8,0x6e,0x6e),
                                           Color.FromArgb(0xa8,0x64,0x64),
                                           Color.FromArgb(0xa8,0x5b,0x5b),
                                           Color.FromArgb(0xa8,0x51,0x51),
                                           Color.FromArgb(0xa8,0x48,0x48),
                                           Color.FromArgb(0xa8,0x3e,0x3e),
                                           Color.FromArgb(0xa8,0x34,0x34),
                                           Color.FromArgb(0xa8,0x2b,0x2b),
                                           Color.FromArgb(0xa8,0x21,0x21),
                                           Color.FromArgb(0xff, 0xff, 0x00),
                                           Color.FromArgb(0xff, 0xff, 0xff) };

        // cherry
         Color[] palette10 = new Color[16] { Color.FromArgb(0xff,0xff,0xff),
                                           Color.FromArgb(0xae,0x9f,0x9e),
                                           Color.FromArgb(0x41,0x19,0x18),
                                           Color.FromArgb(0x9b,0x76,0x75),
                                           Color.FromArgb(0x93,0x5e,0x5d),
                                           Color.FromArgb(0x8c,0x47,0x46),
                                           Color.FromArgb(0x85,0x30,0x2f),
                                           Color.FromArgb(0x7d,0x18,0x18),
                                           Color.FromArgb(0x73,0x18,0x18),
                                           Color.FromArgb(0x69,0x18,0x18),
                                           Color.FromArgb(0x5e,0x18,0x18),
                                           Color.FromArgb(0x54,0x18,0x18),
                                           Color.FromArgb(0x49,0x18,0x18),
                                           Color.FromArgb(0x39,0x19,0x18),
                                           Color.FromArgb(0x5d,0x43,0x18),
                                           Color.FromArgb(0xff, 0xff, 0xff) };


        // strawberry       
        Color[] palette11 = new Color[16] { Color.FromArgb(0x30,0x55,0x2c),
                                           Color.FromArgb(0xb1,0x85,0x70),
                                           Color.FromArgb(0xb1,0x6a,0x58),
                                           Color.FromArgb(0x61,0x5d,0x34),
                                           Color.FromArgb(0x64,0x18,0x18),
                                           Color.FromArgb(0x7b,0x1b,0x19),
                                           Color.FromArgb(0x92,0x1e,0x1a),
                                           Color.FromArgb(0x99,0x21,0x1b),
                                           Color.FromArgb(0xa1,0x23,0x1c),
                                           Color.FromArgb(0xa4,0x2d,0x25),
                                           Color.FromArgb(0xa6,0x37,0x2e),
                                           Color.FromArgb(0xa8,0x41,0x36),
                                           Color.FromArgb(0xab,0x4b,0x3f),
                                           Color.FromArgb(0x18,0x46,0x18),
                                           Color.FromArgb(0x34,0x63,0x40),
                                           Color.FromArgb(0xff, 0xff, 0xff) };


        // orange
        Color[] palette12 = new Color[16] { Color.FromArgb(0x18,0x18,0x18),
                                           Color.FromArgb(0x94,0x94,0x94),
                                           Color.FromArgb(0x93,0x8b,0x77),
                                           Color.FromArgb(0x92,0x83,0x5b),
                                           Color.FromArgb(0x91,0x7b,0x3e),
                                           Color.FromArgb(0x8f,0x73,0x36),
                                           Color.FromArgb(0x91,0x6a,0x30),
                                           Color.FromArgb(0x94,0x61,0x2b),
                                           Color.FromArgb(0x98,0x58,0x27),
                                           Color.FromArgb(0x9b,0x50,0x22),
                                           Color.FromArgb(0x9e,0x47,0x1d),
                                           Color.FromArgb(0x97,0x33,0x18),
                                           Color.FromArgb(0x64,0x36,0x26),
                                           Color.FromArgb(0x5e,0x51,0x25),
                                           Color.FromArgb(0x2d,0x4e,0x1b),
                                           Color.FromArgb(0xff, 0xff, 0xff) };


        // green pill pickup
        Color[] palette13 = new Color[16] { Color.FromArgb(0xff,0xff,0xff),
                                           Color.FromArgb(0x9e,0xa8,0x81),
                                           Color.FromArgb(0x81,0xa8,0x64),
                                           Color.FromArgb(0x6e,0xa8,0x48),
                                           Color.FromArgb(0x64,0xa8,0x34),
                                           Color.FromArgb(0x5b,0xa8,0x2b),
                                           Color.FromArgb(0x51,0xa8,0x21),
                                           Color.FromArgb(0x48,0x9e,0x21),
                                           Color.FromArgb(0x3e,0x94,0x21),
                                           Color.FromArgb(0x34,0x8b,0x21),
                                           Color.FromArgb(0x2b,0x81,0x21),
                                           Color.FromArgb(0x21,0x78,0x21),
                                           Color.FromArgb(0x21,0x6e,0x21),
                                           Color.FromArgb(0x21,0x5b,0x21),

                                           Color.FromArgb(0xff, 0xff, 0x00),
                                           Color.FromArgb(0xff, 0xff, 0xff) };


        // red apple bonus
        Color[] palette14 = new Color[16] { Color.FromArgb(0x18,0x18,0x18),
                                           Color.FromArgb(0xb1, 0xb1, 0xb1),
                                           Color.FromArgb(0xb1, 0xb1, 0xb1),
                                           Color.FromArgb(0xa9, 0x46, 0x31),
                                           Color.FromArgb(0xa9, 0x2a, 0x1e),
                                           Color.FromArgb(0x94, 0x18, 0x18),
                                           Color.FromArgb(0x8b, 0x19, 0x18),
                                           Color.FromArgb(0x82, 0x19, 0x18),
                                           Color.FromArgb(0x79, 0x19, 0x18),
                                           Color.FromArgb(0x76, 0x19, 0x18),
                                           Color.FromArgb(0x72, 0x19, 0x18),
                                           Color.FromArgb(0x75, 0x3c, 0x18),
                                           Color.FromArgb(0x61, 0x4e, 0x18),
                                           Color.FromArgb(0x67, 0x25, 0x18),
                                           Color.FromArgb(0x57, 0x3f, 0x18),
                                           Color.FromArgb(0xff, 0xff, 0xff) };


        // inky light blue ghost 
        Color[] palette15 = new Color[16] { Color.FromArgb(0x34,0x34,0x34),            //0
                                           Color.FromArgb(0x92,0xa7,0xb1),              //1
                                           Color.FromArgb(0x70,0x9e,0xb1),    //2
                                           Color.FromArgb(0x4e,0x96,0xb1),    //3
                                           Color.FromArgb(0x2c,0x8d,0xb1),    //4
                                           Color.FromArgb(0x27,0x83,0xb1),    //5
                                           Color.FromArgb(0x22,0x79,0xaa),    //6
                                           Color.FromArgb(0x1d,0x6f,0xa7),    //7
                                           Color.FromArgb(0x1b,0x64,0x9f),    //8
                                           Color.FromArgb(0x19,0x5a,0x96),    //9
                                           Color.FromArgb(0x19,0x50,0x8c),    //a
                                           Color.FromArgb(0x18,0x46,0x82),    //b
                                           Color.FromArgb(0x18,0x3b,0x78),    //c
                                           Color.FromArgb(0x18,0x30,0x6d),    //d
                                           Color.FromArgb(0xa8,0xa8,0xa8),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        // blinky red ghost 
        Color[] palette16 = new Color[16] { Color.FromArgb(0x34,0x34,0x34),            //0
                                           Color.FromArgb(0xa8,0x34,0x48),              //1
                                           Color.FromArgb(0xa8,0x2b,0x34),    //2
                                           Color.FromArgb(0xa8,0x18,0x1c),    //3
                                           Color.FromArgb(0x9e,0x18,0x1c),    //4
                                           Color.FromArgb(0x94,0x18,0x1c),    //5
                                           Color.FromArgb(0x8b,0x18,0x1c),    //6
                                           Color.FromArgb(0x81,0x18,0x1c),    //7
                                           Color.FromArgb(0x78,0x18,0x1c),    //8
                                           Color.FromArgb(0x6e,0x18,0x1c),    //9
                                           Color.FromArgb(0x64,0x18,0x1c),    //a
                                           Color.FromArgb(0x60,0x18,0x1c),    //b
                                           Color.FromArgb(0x56,0x18,0x1c),    //c
                                           Color.FromArgb(0x4c,0x18,0x1c),    //d
                                           Color.FromArgb(0xa8,0xa8,0xa8),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f


        // pinky pink ghost 
        Color[] palette17 = new Color[16] { Color.FromArgb(0x34,0x34,0x34),       //0
                                           Color.FromArgb(0xa8,0x9e,0x9e),         //1
                                           Color.FromArgb(0xa8,0x8b,0x8b),    //2
                                           Color.FromArgb(0xa8,0x81,0x81),    //3
                                           Color.FromArgb(0xa8,0x78,0x78),    //4
                                           Color.FromArgb(0xa8,0x6e,0x6e),    //5
                                           Color.FromArgb(0xa8,0x64,0x64),    //6
                                           Color.FromArgb(0xa8,0x5b,0x5b),    //7
                                           Color.FromArgb(0xa8,0x51,0x51),    //8
                                           Color.FromArgb(0xa8,0x48,0x48),    //9
                                           Color.FromArgb(0xa8,0x3e,0x3e),    //a
                                           Color.FromArgb(0xa8,0x34,0x34),    //b
                                           Color.FromArgb(0xa8,0x2b,0x2b),    //c
                                           Color.FromArgb(0xa8,0x21,0x21),    //d
                                           Color.FromArgb(0xa8,0xa8,0xa8),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        // Funky green ghost 
        Color[] palette18 = new Color[16] { Color.FromArgb(0x34,0x34,0x34),       //0
                                           Color.FromArgb(0x7c,0xb1,0x9b),         //1
                                           Color.FromArgb(0x70,0xa9,0x91),    //2
                                           Color.FromArgb(0x66,0xa1,0x88),    //3
                                           Color.FromArgb(0x5d,0x9a,0x7f),    //4
                                           Color.FromArgb(0x52,0x93,0x76),    //5
                                           Color.FromArgb(0x49,0x8b,0x6e),    //6
                                           Color.FromArgb(0x43,0x85,0x66),    //7
                                           Color.FromArgb(0x3d,0x7f,0x5f),    //8
                                           Color.FromArgb(0x38,0x79,0x57),    //9
                                           Color.FromArgb(0x32,0x73,0x4f),    //a
                                           Color.FromArgb(0x30,0x6e,0x49),    //b
                                           Color.FromArgb(0x2f,0x69,0x43),    //c
                                           Color.FromArgb(0x2d,0x64,0x3d),    //d
                                           Color.FromArgb(0xb1,0xb1,0xb1),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        // spunky grey ghost
        Color[] palette19 = new Color[16] { Color.FromArgb(0x34,0x34,0x34),       //0
                                           Color.FromArgb(0x94, 0x9e, 0xa8),         //1
                                           Color.FromArgb(0x8b, 0x94, 0xa8),    //2
                                           Color.FromArgb(0x81, 0x8b, 0x9e),    //3
                                           Color.FromArgb(0x78, 0x81, 0x94),    //4
                                           Color.FromArgb(0x6e, 0x78, 0x8b),    //5
                                           Color.FromArgb(0x64, 0x6e, 0x81),    //6
                                           Color.FromArgb(0x5b, 0x64, 0x78),    //7
                                           Color.FromArgb(0x51, 0x5b, 0x6e),    //8
                                           Color.FromArgb(0x48, 0x51, 0x64),    //9
                                           Color.FromArgb(0x3e, 0x48, 0x5b),    //a
                                           Color.FromArgb(0x34, 0x3e, 0x51),    //b
                                           Color.FromArgb(0x2b, 0x34, 0x48),    //c
                                           Color.FromArgb(0x21, 0x2b, 0x3e),    //d
                                           Color.FromArgb(0xa8, 0xa8, 0xa8),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        // spiny grey parts on intro 3
        Color[] palette20 = new Color[16] { Color.FromArgb(0x21,0x21,0x21),       //0
                                           Color.FromArgb(0x24, 0x24, 0x24),       //1
                                           Color.FromArgb(0x28, 0x28, 0x28),    //2
                                           Color.FromArgb(0x2b, 0x2b, 0x2b),    //3
                                           Color.FromArgb(0x2f, 0x2f, 0x2f),    //4
                                           Color.FromArgb(0x32, 0x32, 0x32),    //5
                                           Color.FromArgb(0x36, 0x36, 0x36),    //6
                                           Color.FromArgb(0x3a, 0x3a, 0x3a),    //7
                                           Color.FromArgb(0x3f, 0x3f, 0x3f),    //8
                                           Color.FromArgb(0x43, 0x43, 0x43),    //9
                                           Color.FromArgb(0x48, 0x48, 0x48),    //a
                                           Color.FromArgb(0x5a, 0x5a, 0x5a),    //b
                                           Color.FromArgb(0x65, 0x65, 0x65),    //c
                                           Color.FromArgb(0x70, 0x70, 0x70),    //d
                                           Color.FromArgb(0x88, 0x88, 0x88),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        // spiny buff parts on intro 3
        Color[] palette21 = new Color[16] { Color.FromArgb(0x42, 0x30, 0x24),       //0
                                           Color.FromArgb(0x45, 0x33, 0x27),       //1
                                           Color.FromArgb(0x47, 0x37, 0x2a),    //2
                                           Color.FromArgb(0x49, 0x3a, 0x2e),    //3
                                           Color.FromArgb(0x4c, 0x3e, 0x31),    //4
                                           Color.FromArgb(0x4e, 0x42, 0x35),    //5
                                           Color.FromArgb(0x51, 0x45, 0x39),    //6
                                           Color.FromArgb(0x53, 0x49, 0x3c),    //7
                                           Color.FromArgb(0x55, 0x4c, 0x40),    //8
                                           Color.FromArgb(0x5f, 0x55, 0x48),    //9
                                           Color.FromArgb(0x69, 0x5e, 0x51),    //a
                                           Color.FromArgb(0x72, 0x67, 0x5a),    //b
                                           Color.FromArgb(0x7f, 0x73, 0x65),    //c
                                           Color.FromArgb(0x98, 0x8e, 0x76),    //d
                                           Color.FromArgb(0xb1, 0xa8, 0x88),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f


        // bell bonus
        Color[] palette22 = new Color[16] { Color.FromArgb(0x00, 0x00, 0x00),       //0
                                           Color.FromArgb(0x4c, 0x43, 0x1d),       //1
                                           Color.FromArgb(0xab, 0xa8, 0x92),    //2
                                           Color.FromArgb(0xa6, 0x9f, 0x73),    //3
                                           Color.FromArgb(0xa1, 0x96, 0x55),    //4
                                           Color.FromArgb(0x9b, 0x8d, 0x36),    //5
                                           Color.FromArgb(0x96, 0x83, 0x18),    //6
                                           Color.FromArgb(0x90, 0x7f, 0x18),    //7
                                           Color.FromArgb(0x8b, 0x7b, 0x19),    //8
                                           Color.FromArgb(0x85, 0x76, 0x19),    //9
                                           Color.FromArgb(0x7b, 0x6d, 0x19),    //a
                                           Color.FromArgb(0x71, 0x64, 0x1b),    //b
                                           Color.FromArgb(0x67, 0x5b, 0x1b),    //c
                                           Color.FromArgb(0x5d, 0x52, 0x1c),    //d
                                           Color.FromArgb(0x54, 0x4a, 0x1c),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        // green apple special bonus
        Color[] palette23 = new Color[16] { Color.FromArgb(0x56, 0x30, 0x18),       //0
                                           Color.FromArgb(0xb1, 0xb1, 0xb1),       //1
                                           Color.FromArgb(0x93, 0x9c, 0x9a),    //2
                                           Color.FromArgb(0x75, 0x88, 0x36),    //3
                                           Color.FromArgb(0x57, 0x7d, 0x2b),    //4
                                           Color.FromArgb(0x4c, 0x79, 0x27),    //5
                                           Color.FromArgb(0x43, 0x76, 0x23),    //6
                                           Color.FromArgb(0x39, 0x72, 0x1f),    //7
                                           Color.FromArgb(0x47, 0x70, 0x1d),    //8
                                           Color.FromArgb(0x55, 0x6f, 0x1c),    //9
                                           Color.FromArgb(0x64, 0x6f, 0x1b),    //a
                                                     Color.FromArgb(0x75, 0x3c, 0x18),
                                           Color.FromArgb(0x61, 0x4e, 0x18),

                                          // Color.FromArgb(0xff, 0x00, 0x00),    //b   // UNKNOWN CAN NOT SEE
                                          // Color.FromArgb(0x00, 0x00, 0xff),    //c   // UNKNOW CAN NOT SEE
                                           Color.FromArgb(0x31, 0x4e, 0x1c),    //
                                           Color.FromArgb(0x27, 0x3f, 0x18),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f




        // pacman walking on score menu screen
        Color[] palette24 = new Color[16] { Color.FromArgb(0xa3, 0xa2, 0x28),       //0
                                           Color.FromArgb(0xa1, 0x96, 0x26),       //1
                                           Color.FromArgb(0x9f, 0x8a, 0x24),    //2
                                           Color.FromArgb(0x9c, 0x7e, 0x21),    //3
                                           Color.FromArgb(0x7e, 0x57, 0x1b),    //4
                                           Color.FromArgb(0x77, 0x4d, 0x19),    //5
                                           Color.FromArgb(0x6f, 0x43, 0x18),    //6
                                           Color.FromArgb(0x43, 0x2d, 0x18),    //7
                                           Color.FromArgb(0x18, 0x18, 0x18),    //8
                                           Color.FromArgb(0x51, 0x18, 0x18),    //9
                                           Color.FromArgb(0x89, 0x18, 0x18),    //a
                                           Color.FromArgb(0x37, 0x3d, 0x9e),    //b   
                                           Color.FromArgb(0x5a, 0x4b, 0x1c),    //c   
                                           Color.FromArgb(0x7e, 0x70, 0x21),    //d
                                           Color.FromArgb(0xa5, 0xa5, 0xa7),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        //sweet/candy extra bonus pickup 
        Color[] palette25 = new Color[16] { Color.FromArgb(0xb1, 0xb1, 0xb1),       //0
                                           Color.FromArgb(0xa5, 0xa5, 0xa5),       //1
                                           Color.FromArgb(0x9b, 0x9a, 0x99),    //2
                                           Color.FromArgb(0x88, 0x89, 0x8a),    //3
                                           Color.FromArgb(0x76, 0x78, 0x7b),    //4
                                           Color.FromArgb(0x64, 0x67, 0x6c),    //5
                                           Color.FromArgb(0x8d, 0x74, 0x18),    //6
                                           Color.FromArgb(0x9b, 0x84, 0x33),    //7
                                           Color.FromArgb(0x9b, 0x84, 0x33 ),    //8
                                           Color.FromArgb(0x3d, 0x5c, 0x8e),    //9
                                           Color.FromArgb(0x46, 0x6b, 0x93),    //a
                                           Color.FromArgb(0x4e, 0x79, 0x97),    //b   
                                           Color.FromArgb(0x61, 0x18, 0x18),    //c   
                                           Color.FromArgb(0x79, 0x18, 0x18),    //d
                                           Color.FromArgb(0x90, 0x18, 0x18),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f

        //burger
        Color[] palette26 = new Color[16] { Color.FromArgb(0x81, 0x18, 0x18),       //0
                                           Color.FromArgb(0xff, 0xff, 0xff),       //1 not used
                                           Color.FromArgb(0xff, 0xff, 0xff),    // 2 not used
                                           Color.FromArgb(0x88, 0x6f, 0x4b),    //3 
                                           Color.FromArgb(0x84, 0x68, 0x45),    //4
                                           Color.FromArgb(0x7f, 0x60, 0x3e),    //5
                                           Color.FromArgb(0x79, 0x58, 0x37),    //6
                                           Color.FromArgb(0x76, 0x54, 0x34),    //7
                                           Color.FromArgb(0x73, 0x51, 0x30),    //8
                                           Color.FromArgb(0x70, 0x4c, 0x2d),    //9
                                           Color.FromArgb(0x6d, 0x49, 0x29),    //a
                                           Color.FromArgb(0x6a, 0x45, 0x25),    //b   
                                           Color.FromArgb(0x47, 0x2b, 0x19),    //c   
                                           Color.FromArgb(0x35, 0x66, 0x18),    //d
                                           Color.FromArgb(0x18, 0x42, 0x18),    //e
                                           Color.FromArgb(0xff, 0xff, 0xff) };  // f


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = this.openFileDialog1.FileName;

                data = File.ReadAllBytes(file);
            }

            rebuildPicturebox();
        }

        void rebuildPicturebox()
        { 
            if (bitspetpixel == 4)
            {
                RebuildPicturebox4bpp();
            }
        } 

        //
        // Raw binary roms stores graphics as 16x16 sprites at 4 bits per pixel.
        //
        void RebuildPicturebox4bpp()
        {
            // Step 1 is to convert the roms logical colours into an RGB 8bpp equivalent from our chosen palette.

            if (data == null)
            {
                return;
            }

            Bitmap b = new Bitmap(512, 512);

            int index = 0;
            int bit = 0;

            int size = 16;


            int v = 0;
            while (v + size < 512)
            {
                for (int y = 0; y < 512; y++)
                {
                    for (int x = v; x < v + size; x++)
                    {
                        if (index < data.Length)
                        {
                            byte value = data[index];

                            int c;

                            if (bit ==4)
                            {
                                c = value & 0xf;
                            }
                            else
                            {
                                c = value & 0xf0;
                                c >>= 4;
                            }

                            Color cc = palettes[currentPaletteIndex][c];

                            b.SetPixel(x, y, cc);

                            bit += 4;
                            if (bit == 8)
                            {
                                bit = 0;
                                index++;
                            }
                        }
                        else
                        {
                            b.SetPixel(x, y, Color.Black);
                        }
                    }
                }

                v += size;
            }

            // step 2 is to combine groups of 4 of these 16x16 spites into 1 big 32x32 sprite 
            // Pacmania uses 32x32 sprites.
            Bitmap ss = Convert16x16SpritesInto32x32Sprite(b);
            this.pictureBox1.Image = ss;
        }

        Bitmap Convert16x16SpritesInto32x32Sprite(Bitmap romSprites)
        {
            int size = 32;

            Bitmap spritesheet = new Bitmap(512, 512);

            int w = romSprites.Width / size;
            int h = romSprites.Height / size;

            int numberSprites = w * h;

            int rx = 0;
            int ry = 0;

            int ssx = 0;
            int ssy = 0;

            // int[] dying1  = { 193, 194, 195, 246,247, 248, 249, 250, 251, 252, 253, 254, 255};
            // firhgten int[] spritestoinclude = { 35,36,37, 39,40,41, 42,43,44, 45,46,47, 61,62, 63,  64,65,66, 67,68,69, 70,71,72};
            //  int[] eyes = { 208,209,210,211, 212,213,214,215, 216,217,218,219, 220,221,222,223 };
            //    int[] sue = { 35,36,37,  136, 137,138, 139,140,141,142,143,144, 148,149,150,151,152,153,154,155,156 ,224,225,226,227,228,229, 230,231,232,233,234,235,236,237,238,239,240, 241,242,243,244,245   };  
            //int[] ghosteastscores = { 181, 182, 183, 205, 206, 207 };
            //int[] redpickup = { 86};
            // int[] cherry = { 2 };
            //int[] strawberry = { 1 };
            //int[] orange = { 3 };
            //int[] greenpickup = { 86 };
            //int[] apple = { 0 };

            //  int[] inky = { 35,36,37, 112,113,114,  115, 116,117, 118,119,120 , 196,197,198,  199,200,201, 202,203,204 ,224,225,226,227,228,229, 230,231,232,233,234,235,236,237,238,239,240, 241,242,243,244,245   };  
            // int[] inky2 = { 141, 142, 143 };

            //  int[] scores = { 135, 145,146,147, 157,158, 159, 169, 170, 171, 181, 182, 183, 205, 206, 207 };


            //   int[] clyde = {35,36,37, 26,27,28, 29,30,31, 32,33,34,    88,89,90, 91,92,93, 94,95,96,          224,225,226,227,228,229, 230,231,232,233,234,235,236,237,238,239,240, 241,242,243,244,245   };  

            //   int[] blinky = { 35, 36, 37, 184, 185, 186, 187, 188, 189, 190, 191, 192, 196, 197, 198, 199, 200, 201, 202, 203, 204,  160,161,162,163,164,165,166,167,168, 172, 173,174,175,176,177,178,179,180  ,224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245 };  
            //   int[] pinky = { 35, 36, 37, 184, 185, 186, 187, 188, 189, 190, 191, 192, 196, 197, 198, 199, 200, 201, 202, 203, 204, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245 }; 
            //    int[] funky = { 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 100, 101, 102, 103, 104, 105, 106, 107, 108, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245 };

            // int[] spunky  = { 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 100, 101, 102, 103, 104, 105, 106, 107, 108, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245 };
            // int[] spinningboxinsandboxintro = { 152, 153, 154, 155, 156, 157, 158, 159 };

            //  int[] pacmanwalkinghighscoretable1 = { 98, 99, 109, 110, 111, 121, 122, 123 };
            // int[] pacmanwalkinghighscoretable2 = { 101, 136, 137, 138, 139}; // WHERE are these used though ????
         
          //  int[] spritestoinclude = { 32 };

          //   int[] spritestoinclude = { 35,36,37,  136, 137,138, 139,140,141,142,143,144, 148,149,150,151,152,153,154,155,156 ,224,225,226,227,228,229, 230,231,232,233,234,235,236,237,238,239,240, 241,242,243,244,245   };  


            int spritenum = 0;
        
            for (int i =0;i < 256; i++)
            {
                for (int q = 0; q < 4; q++)
                {
                   // if (spritenum >96)
                  //  if (spritestoinclude.Contains(spritenum))
                    {
                        
                        // copy 16x16
                        for (int yy = 0; yy < 16; yy++)
                        {
                            for (int xx = 0; xx < 16; xx++)
                            {
                                Color c = romSprites.GetPixel(rx + xx, ry + yy);

                                // spritesheet.SetPixel(rx + xx, ry + yy, c);

                                int xo = 0;
                                int yo = 0;
                                if (q == 1 || q == 3)
                                {
                                    xo = 16;
                                }
                                if (q == 0 || q == 1)
                                {
                                    yo = 16;
                                }

                                int xxx = 15 - yy;

                                spritesheet.SetPixel(ssx + xxx + yo, ssy + xx + xo, c);

                            }
                        }
                    }
                  

                    ry += 16;
                    if (ry >= romSprites.Height)
                    {
                        rx += 16;
                        ry = 0;
                    }
                }

             //   if (spritenum > 96)
            //    if (spritestoinclude.Contains(spritenum))
                {
                    ssx += 32;
                    if (ssx >= spritesheet.Width)
                    {
                        ssx = 0;
                        ssy += 32;
                    }
                }
                spritenum++;

            }

            return spritesheet;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = this.saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = this.saveFileDialog1.FileName;

                this.pictureBox1.Image.Save(file);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             currentPaletteIndex = comboBox1.SelectedIndex;
            rebuildPicturebox();
        }
    }
}

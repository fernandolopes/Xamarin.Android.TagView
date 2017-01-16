using System;
using Android.Graphics;

namespace com.cunoraz.tagview
{
    public static class Constants
    {

        //use dp and sp, not px

        //----------------- separator TagView-----------------//
        public static float DEFAULT_LINE_MARGIN = 5;
        public static float DEFAULT_TAG_MARGIN = 5;
        public static float DEFAULT_TAG_TEXT_PADDING_LEFT = 8;
        public static float DEFAULT_TAG_TEXT_PADDING_TOP = 5;
        public static float DEFAULT_TAG_TEXT_PADDING_RIGHT = 8;
        public static float DEFAULT_TAG_TEXT_PADDING_BOTTOM = 5;

        public static float LAYOUT_WIDTH_OFFSET = 2;

        //----------- separator Tag Item-----------------//
        public static float DEFAULT_TAG_TEXT_SIZE = 14f;
        public static float DEFAULT_TAG_DELETE_INDICATOR_SIZE = 14f;
        public static float DEFAULT_TAG_LAYOUT_BORDER_SIZE = 0f;
        public static float DEFAULT_TAG_RADIUS = 100;
        public static int DEFAULT_TAG_LAYOUT_COLOR = Color.ParseColor("#AED374");
        public static int DEFAULT_TAG_LAYOUT_COLOR_PRESS = Color.ParseColor("#88363636");
        public static int DEFAULT_TAG_TEXT_COLOR = Color.ParseColor("#ffffff");
        public static int DEFAULT_TAG_DELETE_INDICATOR_COLOR = Color.ParseColor("#ffffff");
        public static int DEFAULT_TAG_LAYOUT_BORDER_COLOR = Color.ParseColor("#ffffff");
        public static String DEFAULT_TAG_DELETE_ICON = "×";
        public static Boolean DEFAULT_TAG_IS_DELETABLE = false;

    }
}
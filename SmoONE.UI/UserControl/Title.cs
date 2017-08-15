using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;
using System.Drawing.Design;

namespace SmoONE.UI.UserControl
{
    [System.ComponentModel.ToolboxItem(true)]
    partial class Title : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 标题文本
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("标题文本")]
        public string Text
        {
            get
            {
                return this.lblTitle.Text;
            }
            set
            {
                this.lblTitle.Text = value;
            }
        }
        /// <summary>
        /// 标题图片
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("标题图片"),Editor("Smobiler.Core.Design.ResourceFontEditor, Smobiler.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=f1ac7264a7cfc183", typeof(UITypeEditor))]
        public string ResourceID
        {
            get
            {
                return fontTitle.ResourceID;
            }
            set
            {
                this.fontTitle.ResourceID = value;
            }
        }

        private void tpTitle_Press(object sender, EventArgs e)
        {
            this.Form.Close();
        }
    }
}
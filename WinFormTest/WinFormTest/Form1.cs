﻿using DSkin.Controls;
using DSkin.DirectUI;
using DSkin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : DSkinForm
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                DSkinTreeViewNode dNode = new DSkinTreeViewNode();
                dNode.Text = "根节点" + i.ToString();
                dNode.IsCustom = true;
                dNode.ShowCheckBox = false;
                dSkinTreeView1.Nodes.Add(dNode);
                for (int j = 0; j < 10; j++)
                {
                    DSkinTreeViewNode nodenode = new DSkinTreeViewNode();
                    nodenode.Text = "子节点" + j.ToString();
                    dNode.Nodes.Add(nodenode);
                    for (int k = 0; k < 10; k++)
                    {
                        DSkinTreeViewNode nodenodenode = new DSkinTreeViewNode();
                        nodenodenode.Text = "子子节点" + k.ToString();
                        //nodenodenode.Template = typeof(DSkinTreeViewNodeTemplate);
                        nodenode.Nodes.Add(nodenodenode);
                    }
                }
            }
        }
    }
}
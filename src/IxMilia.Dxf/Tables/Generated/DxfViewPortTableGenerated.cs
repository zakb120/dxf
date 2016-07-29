// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System.Linq;
using System.Collections.Generic;
using IxMilia.Dxf.Sections;

namespace IxMilia.Dxf.Tables
{
    public partial class DxfViewPortTable : DxfTable
    {
        internal override DxfTableType TableType { get { return DxfTableType.ViewPort; } }

        public List<DxfViewPort> Items { get; private set; }

        protected override IEnumerable<DxfSymbolTableFlags> GetSymbolItems()
        {
            return Items;
        }

        public DxfViewPortTable()
        {
            Items = new List<DxfViewPort>();
            Normalize();
        }

        internal static DxfTable ReadFromBuffer(DxfCodePairBufferReader buffer)
        {
            var table = new DxfViewPortTable();
            table.Items.Clear();
            while (buffer.ItemsRemain)
            {
                var pair = buffer.Peek();
                buffer.Advance();
                if (DxfTablesSection.IsTableEnd(pair))
                {
                    break;
                }

                if (pair.Code == 0 && pair.StringValue == DxfTable.ViewPortText)
                {
                    var item = DxfViewPort.FromBuffer(buffer);
                    table.Items.Add(item);
                }
            }

            return table;
        }
    }
}
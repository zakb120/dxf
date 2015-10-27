// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfLayout class
    /// </summary>
    public partial class DxfLayout : DxfPlotSettings
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.Layout; } }

        public string LayoutName { get; set; }
        public int LayoutFlags { get; set; }
        public int TabOrder { get; set; }
        public DxfPoint MinimumLimits { get; set; }
        public DxfPoint MaximumLimits { get; set; }
        public DxfPoint InsertionBasePoint { get; set; }
        public DxfPoint MinimumExtents { get; set; }
        public DxfPoint MaximumExtents { get; set; }
        public double Elevation { get; set; }
        public DxfPoint UcsOrigin { get; set; }
        public DxfVector UcsXAxis { get; set; }
        public DxfVector UcsYAxis { get; set; }
        public DxfUcsOrthographicType UcsOrthographicType { get; set; }
        public uint ViewportHandle { get; set; }
        public uint TableRecordHandle { get; set; }
        public uint TableRecordBaseHandle { get; set; }

        // LayoutFlags flags

        public bool IsPsLtScale
        {
            get { return DxfHelpers.GetFlag(LayoutFlags, 1); }
            set
            {
                var flags = LayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 1);
                LayoutFlags = flags;
            }
        }

        public bool IsLimCheck
        {
            get { return DxfHelpers.GetFlag(LayoutFlags, 2); }
            set
            {
                var flags = LayoutFlags;
                DxfHelpers.SetFlag(value, ref flags, 2);
                LayoutFlags = flags;
            }
        }

        public DxfLayout()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.LayoutName = null;
            this.LayoutFlags = 0;
            this.TabOrder = 0;
            this.MinimumLimits = DxfPoint.Origin;
            this.MaximumLimits = DxfPoint.Origin;
            this.InsertionBasePoint = DxfPoint.Origin;
            this.MinimumExtents = DxfPoint.Origin;
            this.MaximumExtents = DxfPoint.Origin;
            this.Elevation = 0.0;
            this.UcsOrigin = DxfPoint.Origin;
            this.UcsXAxis = DxfVector.XAxis;
            this.UcsYAxis = DxfVector.YAxis;
            this.UcsOrthographicType = DxfUcsOrthographicType.NotOrthographic;
            this.ViewportHandle = 0u;
            this.TableRecordHandle = 0u;
            this.TableRecordBaseHandle = 0u;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbLayout"));
            pairs.Add(new DxfCodePair(1, (this.LayoutName)));
            pairs.Add(new DxfCodePair(70, (short)(this.LayoutFlags)));
            pairs.Add(new DxfCodePair(71, (short)(this.TabOrder)));
            pairs.Add(new DxfCodePair(10, MinimumLimits?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, MinimumLimits?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(11, MaximumLimits?.X ?? default(double)));
            pairs.Add(new DxfCodePair(21, MaximumLimits?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(12, InsertionBasePoint?.X ?? default(double)));
            pairs.Add(new DxfCodePair(22, InsertionBasePoint?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(32, InsertionBasePoint?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(14, MinimumExtents?.X ?? default(double)));
            pairs.Add(new DxfCodePair(24, MinimumExtents?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(34, MinimumExtents?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(15, MaximumExtents?.X ?? default(double)));
            pairs.Add(new DxfCodePair(25, MaximumExtents?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(35, MaximumExtents?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(146, (this.Elevation)));
            pairs.Add(new DxfCodePair(13, UcsOrigin?.X ?? default(double)));
            pairs.Add(new DxfCodePair(23, UcsOrigin?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(33, UcsOrigin?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(16, UcsXAxis?.X ?? default(double)));
            pairs.Add(new DxfCodePair(26, UcsXAxis?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(36, UcsXAxis?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(17, UcsYAxis?.X ?? default(double)));
            pairs.Add(new DxfCodePair(27, UcsYAxis?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(37, UcsYAxis?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(76, (short)(this.UcsOrthographicType)));
            pairs.Add(new DxfCodePair(331, UIntHandle(this.ViewportHandle)));
            pairs.Add(new DxfCodePair(345, UIntHandle(this.TableRecordHandle)));
            pairs.Add(new DxfCodePair(346, UIntHandle(this.TableRecordBaseHandle)));
        }
    }

}

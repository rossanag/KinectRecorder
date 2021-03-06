﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace VirtualKinect
{
    [Serializable]
    public class SkeletonData
    {
        [XmlArrayItem(Type = typeof(Joint))]
        public JointsCollection Joints;
        public Vector Position;

        [XmlAttribute]
        public Microsoft.Research.Kinect.Nui.SkeletonQuality Quality;
        [XmlAttribute]
        public int TrackingID;
        [XmlAttribute]
        public Microsoft.Research.Kinect.Nui.SkeletonTrackingState TrackingState;
        [XmlAttribute]
        public int UserIndex;

        [XmlIgnoreAttribute]
        public Microsoft.Research.Kinect.Nui.SkeletonData NUI
        {
            set
            {
                this.Joints = new JointsCollection();
                this.Joints.NUI = value.Joints;
                this.Position = new Vector();
                this.Position.NUI = value.Position;
                this.TrackingID = value.TrackingID;
                this.TrackingState = value.TrackingState;
                this.UserIndex = value.UserIndex;
            }
        }
    }
}

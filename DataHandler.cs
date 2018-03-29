using System;
using ReadWriteCSV;
using Microsoft.Kinect;
using System.Collections.Generic;

public class DataHandler
{
    // The list of joint data entries that is being built up 
    // and will eventually be printed to CSV
    private List<JointData> data;

    public DataHandler()
    {
        this.data = new List<JointData>();
    }



    // Adds a line of joint data to the growing list of joint data
    public void AddJointData(string time, CameraSpacePoint Head, CameraSpacePoint Neck, CameraSpacePoint SpineShoulder,
            CameraSpacePoint SpineMid, CameraSpacePoint SpineBase, CameraSpacePoint RightShoulder,
            CameraSpacePoint LeftShoulder, CameraSpacePoint RightElbow, CameraSpacePoint LeftElbow,
            CameraSpacePoint RightWrist, CameraSpacePoint LeftWrist, CameraSpacePoint RightHand,
            CameraSpacePoint LeftHand, CameraSpacePoint RightThumb, CameraSpacePoint LeftThumb,
            CameraSpacePoint RightHandTip, CameraSpacePoint LeftHandTip, CameraSpacePoint RightHip,
            CameraSpacePoint LeftHip, CameraSpacePoint RightKnee, CameraSpacePoint LeftKnee,
            CameraSpacePoint RightAnkle, CameraSpacePoint LeftAnkle, CameraSpacePoint RightFoot,
            CameraSpacePoint LeftFoot, bool marking)
    {
        data.Add(new JointData(time, Head, Neck, SpineShoulder,
            SpineMid, SpineBase, RightShoulder,
            LeftShoulder, RightElbow, LeftElbow,
            RightWrist, LeftWrist, RightHand,
            LeftHand, RightThumb, LeftThumb,
            RightHandTip, LeftHandTip, RightHip,
            LeftHip, RightKnee, LeftKnee,
            RightAnkle, LeftAnkle, RightFoot,
            LeftFoot, marking));
    }

    public void WriteToFile(string location)
    {
        // Write all entries in data list to file
        using (CsvFileWriter writer = new CsvFileWriter(location))
        {

            // write header
            CsvRow header = new CsvRow();

            header.Add("Time");

            header.Add("Head X"); header.Add("Head Y"); header.Add("Head Z");
            header.Add("Neck X"); header.Add("Neck Y"); header.Add("Neck Z");

            header.Add("SpineShoulder X"); header.Add("SpineShoulder Y"); header.Add("SpineShoulder Z");
            header.Add("SpineMid X"); header.Add("SpineMid Y"); header.Add("SpineMid Z");
            header.Add("SpineBase X"); header.Add("SpineBase Y"); header.Add("SpineBase Z");

            header.Add("RightShoulder X"); header.Add("RightShoulder Y"); header.Add("RightShoulder Z");
            header.Add("LeftShoulder X"); header.Add("LeftShoulder Y"); header.Add("LeftShoulder Z");
            header.Add("RightElbow X"); header.Add("RightElbow Y"); header.Add("RightElbow Z");
            header.Add("LeftElbow X"); header.Add("LeftElbow Y"); header.Add("LeftElbow Z");
            header.Add("RightWrist X"); header.Add("RightWrist Y"); header.Add("RightWrist Z");
            header.Add("LeftWrist X"); header.Add("LeftWrist Y"); header.Add("LeftWrist Z");
            header.Add("RightHand X"); header.Add("RightHand Y"); header.Add("RightHand Z");
            header.Add("LeftHand X"); header.Add("LeftHand Y"); header.Add("LeftHand Z");
            header.Add("RightThumb X"); header.Add("RightThumb Y"); header.Add("RightThumb Z");
            header.Add("LeftThumb X"); header.Add("LeftThumb Y"); header.Add("LeftThumb Z");
            header.Add("RightHandTip X"); header.Add("RightHandTip Y"); header.Add("RightHandTip Z");
            header.Add("LeftHandTip X"); header.Add("LeftHandTip Y"); header.Add("LeftHandTip Z");

            header.Add("RightHip X"); header.Add("RightHip Y"); header.Add("RightHip Z");
            header.Add("LeftHip X"); header.Add("LeftHip Y"); header.Add("LeftHip Z");
            header.Add("RightKnee X"); header.Add("RightKnee Y"); header.Add("RightKnee Z");
            header.Add("LeftKnee X"); header.Add("LeftKnee Y"); header.Add("LeftKnee Z");
            header.Add("RightAnkle X"); header.Add("RightAnkle Y"); header.Add("RightAnkle Z");
            header.Add("LeftAnkle X"); header.Add("LeftAnkle Y"); header.Add("LeftAnkle Z");
            header.Add("RightFoot X"); header.Add("RightFoot Y"); header.Add("RightFoot Z");
            header.Add("LeftFoot X"); header.Add("LeftFoot Y"); header.Add("LeftFoot Z");

            header.Add("Trial In Progress?");

            writer.WriteRow(header);

            // write each line of data
            foreach (JointData d in data)
            {
                CsvRow row = new CsvRow();

                row.Add(d.time);

                row.Add(d.Head.X.ToString()); row.Add(d.Head.Y.ToString()); row.Add(d.Head.Z.ToString());
                row.Add(d.Neck.X.ToString()); row.Add(d.Neck.Y.ToString()); row.Add(d.Neck.Z.ToString());

                row.Add(d.SpineShoulder.X.ToString()); row.Add(d.SpineShoulder.Y.ToString()); row.Add(d.SpineShoulder.Z.ToString());
                row.Add(d.SpineMid.X.ToString()); row.Add(d.SpineMid.Y.ToString()); row.Add(d.SpineMid.Z.ToString());
                row.Add(d.SpineBase.X.ToString()); row.Add(d.SpineBase.Y.ToString()); row.Add(d.SpineBase.Z.ToString());

                row.Add(d.RightShoulder.X.ToString()); row.Add(d.RightShoulder.Y.ToString()); row.Add(d.RightShoulder.Z.ToString());
                row.Add(d.LeftShoulder.X.ToString()); row.Add(d.LeftShoulder.Y.ToString()); row.Add(d.LeftShoulder.Z.ToString());
                row.Add(d.RightElbow.X.ToString()); row.Add(d.RightElbow.Y.ToString()); row.Add(d.RightElbow.Z.ToString());
                row.Add(d.LeftElbow.X.ToString()); row.Add(d.LeftElbow.Y.ToString()); row.Add(d.LeftElbow.Z.ToString());
                row.Add(d.RightWrist.X.ToString()); row.Add(d.RightWrist.Y.ToString()); row.Add(d.RightWrist.Z.ToString());
                row.Add(d.LeftWrist.X.ToString()); row.Add(d.LeftWrist.Y.ToString()); row.Add(d.LeftWrist.Z.ToString());
                row.Add(d.RightHand.X.ToString()); row.Add(d.RightHand.Y.ToString()); row.Add(d.RightHand.Z.ToString());
                row.Add(d.LeftHand.X.ToString()); row.Add(d.LeftHand.Y.ToString()); row.Add(d.LeftHand.Z.ToString());
                row.Add(d.RightThumb.X.ToString()); row.Add(d.RightThumb.Y.ToString()); row.Add(d.RightThumb.Z.ToString());
                row.Add(d.LeftThumb.X.ToString()); row.Add(d.LeftThumb.Y.ToString()); row.Add(d.LeftThumb.Z.ToString());
                row.Add(d.RightHandTip.X.ToString()); row.Add(d.RightHandTip.Y.ToString()); row.Add(d.RightHandTip.Z.ToString());
                row.Add(d.LeftHandTip.X.ToString()); row.Add(d.LeftHandTip.Y.ToString()); row.Add(d.LeftHandTip.Z.ToString());

                row.Add(d.RightHip.X.ToString()); row.Add(d.RightHip.Y.ToString()); row.Add(d.RightHip.Z.ToString());
                row.Add(d.LeftHip.X.ToString()); row.Add(d.LeftHip.Y.ToString()); row.Add(d.LeftHip.Z.ToString());
                row.Add(d.RightKnee.X.ToString()); row.Add(d.RightKnee.Y.ToString()); row.Add(d.RightKnee.Z.ToString());
                row.Add(d.LeftKnee.X.ToString()); row.Add(d.LeftKnee.Y.ToString()); row.Add(d.LeftKnee.Z.ToString());
                row.Add(d.RightAnkle.X.ToString()); row.Add(d.RightAnkle.Y.ToString()); row.Add(d.RightAnkle.Z.ToString());
                row.Add(d.LeftAnkle.X.ToString()); row.Add(d.LeftAnkle.Y.ToString()); row.Add(d.LeftAnkle.Z.ToString());
                row.Add(d.RightFoot.X.ToString()); row.Add(d.RightFoot.Y.ToString()); row.Add(d.RightFoot.Z.ToString());
                row.Add(d.LeftFoot.X.ToString()); row.Add(d.LeftFoot.Y.ToString()); row.Add(d.LeftFoot.Z.ToString());

                if (d.marking)
                {
                    row.Add("YES");
                }
                else
                {
                    row.Add("NO");
                }

                writer.WriteRow(row);
            }
        }
    }

    // A class that stores joint data to be eventually written to CSV file
    class JointData
    {
        public readonly string time;

        public readonly CameraSpacePoint Head;
        public readonly CameraSpacePoint Neck;

        public readonly CameraSpacePoint SpineShoulder;
        public readonly CameraSpacePoint SpineMid;
        public readonly CameraSpacePoint SpineBase;

        public readonly CameraSpacePoint RightShoulder;
        public readonly CameraSpacePoint LeftShoulder;
        public readonly CameraSpacePoint RightElbow;
        public readonly CameraSpacePoint LeftElbow;
        public readonly CameraSpacePoint RightWrist;
        public readonly CameraSpacePoint LeftWrist;
        public readonly CameraSpacePoint RightHand;
        public readonly CameraSpacePoint LeftHand;
        public readonly CameraSpacePoint RightThumb;
        public readonly CameraSpacePoint LeftThumb;
        public readonly CameraSpacePoint RightHandTip;
        public readonly CameraSpacePoint LeftHandTip;

        public readonly CameraSpacePoint RightHip;
        public readonly CameraSpacePoint LeftHip;
        public readonly CameraSpacePoint RightKnee;
        public readonly CameraSpacePoint LeftKnee;
        public readonly CameraSpacePoint RightAnkle;
        public readonly CameraSpacePoint LeftAnkle;
        public readonly CameraSpacePoint RightFoot;
        public readonly CameraSpacePoint LeftFoot;

        public readonly bool marking;

        public JointData(string time, CameraSpacePoint Head, CameraSpacePoint Neck, CameraSpacePoint SpineShoulder, 
            CameraSpacePoint SpineMid, CameraSpacePoint SpineBase,CameraSpacePoint RightShoulder,
            CameraSpacePoint LeftShoulder, CameraSpacePoint RightElbow, CameraSpacePoint LeftElbow, 
            CameraSpacePoint RightWrist, CameraSpacePoint LeftWrist, CameraSpacePoint RightHand,
            CameraSpacePoint LeftHand, CameraSpacePoint RightThumb, CameraSpacePoint LeftThumb, 
            CameraSpacePoint RightHandTip, CameraSpacePoint LeftHandTip, CameraSpacePoint RightHip, 
            CameraSpacePoint LeftHip, CameraSpacePoint RightKnee, CameraSpacePoint LeftKnee,
            CameraSpacePoint RightAnkle, CameraSpacePoint LeftAnkle, CameraSpacePoint RightFoot,
            CameraSpacePoint LeftFoot, bool marking)
        {
            this.time = time;

            this.Head = Head;
            this.Neck = Neck;
            this.SpineShoulder = SpineShoulder;
            this.SpineMid = SpineMid;
            this.SpineBase = SpineBase;

            this.RightShoulder = RightShoulder;
            this.LeftShoulder = LeftShoulder;
            this.RightElbow = RightElbow;
            this.LeftElbow = LeftElbow;
            this.RightWrist = RightWrist;
            this.LeftWrist = LeftWrist;
            this.RightHand = RightHand;
            this.LeftHand = LeftHand;
            this.RightThumb = RightThumb;
            this.LeftThumb = LeftThumb;
            this.RightHandTip = RightHandTip;
            this.LeftHandTip = LeftHandTip;

            this.RightHip = RightHip;
            this.LeftHip = LeftHip;
            this.RightKnee = RightKnee;
            this.LeftKnee = LeftKnee;
            this.RightAnkle = RightAnkle;
            this.LeftAnkle = LeftAnkle;
            this.RightFoot = RightFoot;
            this.LeftFoot = LeftFoot;

            this.marking = marking;

        }   
    }
}

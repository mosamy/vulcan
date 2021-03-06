using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Ssis2008Emitter.IR.Common;

namespace Ssis2008Emitter.Emitters.TSQL.TextEmitter
{
    public class TextTarget : Target
    {
        private StreamWriter _streamWriter;

        public override void Initialize(string sDetegoRootPath, string sPackageName)
        {
            string sProjectFolder = Path.Combine(sDetegoRootPath, "dump");

            if (Directory.Exists(sProjectFolder))
            {
                Directory.CreateDirectory(sProjectFolder);
            }
            string TextFileName = Path.ChangeExtension(Path.Combine(sProjectFolder, sPackageName), ".txt");
            _streamWriter = File.CreateText(TextFileName);
        }

        public override void DeInitialize()
        {
            if (_streamWriter != null)
            {
                _streamWriter.Close();
            }
        }

        public override void EmitObject(LogicalObject obj)
        {
            LogicalObject objTemp = obj;
            LogicalObject objParent;
            while ((objParent = objTemp.Parent) != null)
            {
                objTemp = objParent;
                _streamWriter.Write("\t");
            }

            _streamWriter.Write("[{0}]: {1}", obj.GetType().Name, obj.Name);

            if (obj is LogicalReference)
            {
                LogicalObject r = ((LogicalReference)obj).RefObject;
                if (r != null)
                {
                    _streamWriter.Write(" ---> {0}:{1}", r.GetType().Name, r.Name);
                }
            }

            _streamWriter.WriteLine();

            foreach (LogicalObject objChildren in obj.Children)
            {
                EmitObject(objChildren);
            }
        }
    }

    public abstract class Target
    {
        public abstract void EmitObject(LogicalObject obj);
        public abstract void Initialize(string sDetegoRootPath, string sPackageName);
        public abstract void DeInitialize();
    }
}

using System;

namespace NeoTestHarness.Xunit
{
    public class CheckpointFixture<T> : CheckpointFixture
    {
        static string GetCheckpointPath()
        {
            var attrib = ContractAttribute.GetCustomAttribute(typeof(T), typeof(CheckpointPathAttribute)) as CheckpointPathAttribute;
            return attrib?.Path ?? throw new Exception($"Missing {nameof(CheckpointPathAttribute)} on {typeof(T).Name}");
        }

        public CheckpointFixture() : base(GetCheckpointPath())
        {
        }
    }
}


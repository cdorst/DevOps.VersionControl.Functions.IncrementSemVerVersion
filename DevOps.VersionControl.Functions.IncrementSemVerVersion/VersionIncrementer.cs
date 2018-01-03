using DevOps.VersionControl.Structures.SemVer;

namespace DevOps.VersionControl.Functions.IncrementSemVerVersion
{
    public static class VersionIncrementer
    {
        public static SemVerVersion Increment(SemVerVersion version, SemVerComponent component = SemVerComponent.Patch)
        {
            switch (component)
            {
                case SemVerComponent.Major:
                    version.Major = version.Major + 1;
                    break;
                case SemVerComponent.Minor:
                    version.Minor = version.Minor + 1;
                    break;
                case SemVerComponent.Patch:
                    version.Patch = version.Patch + 1;
                    break;
            }
            return version;
        }
    }
}

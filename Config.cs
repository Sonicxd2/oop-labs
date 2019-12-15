namespace OOP
{
    public interface Config
    {
        string get(string section, string name);

        double getDouble(string section, string name);

        int getInt(string section, string name);
    }
}
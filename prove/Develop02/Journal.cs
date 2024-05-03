using System.Text.Json;

public class Journal{
    public List<Entry> _entriesList = new List<Entry>();

    public void AddEntry(){
        Entry entry= new Entry();
        entry.WriteEntry();
        _entriesList.Add(entry);
    } 

    public void DisplayAll(){
        foreach(Entry entry in _entriesList){
            entry.Display();
        }
    }

    public void SaveToFile(){
        Console.WriteLine("What will you name the file? ");
        string journalFile = Console.ReadLine() + ".json";
        string jsonData = JsonSerializer.Serialize(_entriesList);
        File.WriteAllText(journalFile, jsonData);

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadToFile(){
        Console.WriteLine("Which file will you load? ");
        string journalFile = Console.ReadLine() + ".json";
        
        try{
            string jsonData = File.ReadAllText(journalFile);
            List<Entry> entries = JsonSerializer.Deserialize<List<Entry>>(jsonData);
            _entriesList.Clear();
            _entriesList.AddRange(entries);

            foreach(Entry entry in entries){
                Console.WriteLine($"{entry._date} \nPrompt: {entry._promptText} \n{entry._promptAnswer}\n");
            }
        }
        catch (FileNotFoundException){
            Console.WriteLine("The file you are looking for might not exist. Please enter the name of the file correctly, without the '.txt'.");
        }

        Console.WriteLine("Data loaded successfully.\n");
    }
}


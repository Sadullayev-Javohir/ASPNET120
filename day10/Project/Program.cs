// class Program
// {
//   static void ProcessEmailsBad()
//   {
//     List<string> emails = new List<string> {"user1@gmail.com", "user2@gmail.com", "user3@gmail.com"};

//     string emailToSend = emails[0];
//     emails.RemoveAt(0);

//     Console.WriteLine($"Sending to {emailToSend}");
//   }
//   static void Main()
//   {
//     ProcessEmailsBad();
//   }
// }

// public class EmailProcessor
// {
//   private Queue<string> _emailQueue = new Queue<string>();

//   public void AddEmail(string email)
//   {
//     _emailQueue.Enqueue(email);
//   }

//   public void ProcessNextEmail()
//   {
//     if (_emailQueue.Count > 0)
//     {
//       string email = _emailQueue.Dequeue();
//       Console.WriteLine($"Sending email to: {email}");
//     }
//     else
//     {
//       Console.WriteLine("Navbat bo'sh");
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var emails = new EmailProcessor();
//     emails.AddEmail("user1@gmail.com");
//     emails.AddEmail("user2@gmail.com");
//     emails.AddEmail("user3@gmail.com");

//     emails.ProcessNextEmail();
//   }
// }

// using System.Diagnostics.Metrics;
// using System.Security.Cryptography;

// public class TextEditor
// {
//   private string _currentText = "";

//   private Stack<string> _history = new Stack<string>();

//   public void Add(string text)
//   {
//     _history.Push(_currentText);
//     _currentText += text;
//     Console.WriteLine($"Current Text: {_currentText}");
//   }

//   public void Remove()
//   {
//     if (_history.Count > 0)
//     {
//       _currentText = _history.Pop();
//       Console.WriteLine($"Undo perfermed. TexT: {_currentText}");
//     }
//     else
//     {
//       Console.WriteLine("Hozircha element yo'q");
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var text = new TextEditor();
//     text.Add("Hello");
//     text.Add("Hello2");
//     text.Remove();
//   }
// }

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

public class Song
{
  public int Id {get;set;}
  public string Title {get;set;}

  public Song(int id, string title)
  {
    Id = id;
    Title = title;
  }

  public override string ToString() => $"{Id} : {Title}";
}

public class MusicPlaylist
{
  private LinkedList<Song> _playlist = new LinkedList<Song>();
  private LinkedListNode<Song>? _currentSong;

  public void AddSong(Song song)
  {
    _playlist.AddLast(song);

    if (_currentSong == null) _currentSong = _playlist.First;
  }

  public void PlayCurrent()
  {
    if (_currentSong == null)
    {
      Console.WriteLine("Playlist bo'sh");
      return;
    }

    Console.WriteLine($"Now playing: -> {_currentSong.Value}");
  }

  public void PlayNext()
  {
    if (_playlist.Count == 0)
    {
      Console.WriteLine("Playlist bo'sh");
      return;
    }

    _currentSong = _currentSong.Next ?? _playlist.First;
    PlayCurrent();
  }

  public void PlayPrevious()
  {
    if (_playlist.Count == 0)
    {
      Console.WriteLine("Playlist bo'sh");
      return;
    }

    _currentSong = _currentSong.Previous ?? _playlist.Last;
    PlayCurrent();
  }
}

class Program
{
  static void Main()
  {
    var playlist = new MusicPlaylist();

    playlist.AddSong(new Song(1, "Shape of you"));
    playlist.AddSong(new Song(2, "Numb"));
    playlist.AddSong(new Song(3, "Believer"));

    playlist.PlayCurrent();

    playlist.PlayNext();
    playlist.PlayCurrent();
    playlist.PlayNext();

    playlist.PlayPrevious();
  }
}

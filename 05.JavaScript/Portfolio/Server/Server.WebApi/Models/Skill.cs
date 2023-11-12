namespace Server.WebApi.Models;

public sealed class Skill
{
    public int Id { get; set; }
    public string ImageUrl {get; set;}
    public byte[] Image { get; set; }
}


//Mevcut Bir klasöre saklama
//Başka bir Sunucuya saklama //ftp kaydetme oluyor
//Cloud'a depolama
//Database saklama
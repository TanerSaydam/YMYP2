namespace Server.WebApi.Models;

public sealed class Skill
{
    public Guid Id { get; set; }
    public string ImageUrl {get; set;}
    public byte[] Image { get; set; }
    public int Order { get; set; }
}


//Mevcut Bir klasöre saklama
//Başka bir Sunucuya saklama //ftp kaydetme oluyor
//Cloud'a depolama
//Database saklama
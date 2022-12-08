using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Grupp1.Models;


public class Movie {
   
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    [Required]
    public string? Id { get; set; }

    public string plot { get; set; } = null!;
    public List<string> genres { get; set; } = null!;
    public int runtime { get; set; } = 0!;
    public List<String> cast { get; set; } = null!;
    public int num_mflix_comments { get; set; } = 0!;
    public string title { get; set; } = null!;
    public string fullplot { get; set; } = null!;
    public List<string> countries { get; set; } = null!;
    public Released? Released { get; set; }
    public List<string> directors { get; set; } = null!;
    public string rated { get; set; } = null!;
    public Award Award {get; set;}
    public LastUpdated Lastupdated { get; set; } = null!;
    public dynamic year { get; set; } = 0!;
    public Imdb Imdb {get; set;} = null!;
    public string type { get; set; } = null!;
    public Tomatoes Tomatoes {get; set;} = null!;

  
    public string poster { get; set; } = null!;
    public List<string> languages { get; set; } = null!;
    public List<string> writers { get; set; } = null!;
    public int metacritic { get; set; } = 0!;

    public Movie(string plot,
    List<string> genres,
    int runtime,
    List<String> cast,
    int num_mflix_comments,
    string title,
    string fullplot,
    List<string> countries,
    DateTime released,
    List<String> directors,
    string rated,
    object award,
    DateTime lastupdated,
    dynamic year,
    object imdb,
    string type,
    object tomatoes,
    object viewer, 
    string poster, 
    List<String> languages, 
    List<String> writers, 
    int metacritic) {

        this.plot = plot;
        this.genres = genres;
        this.runtime = runtime;
        this.cast = cast;
        this.num_mflix_comments = num_mflix_comments;
        this.title = title;
        this.fullplot = fullplot;
        this.countries = countries;
        this.Released = released;
        this.directors = directors;
        this.rated = rated;
        this.Award = (Award?)award;
        this.Lastupdated = lastupdated;
        this.year = year;
        this.Imdb = (Imdb)imdb;
        this.type = type;
        this.Tomatoes = (Tomatoes)tomatoes;
        // this.Viewer = (CustomClassesMovie.TomatoesObject.ViewerObject)viewer;
        this.poster = poster;
        this.languages = languages;
        this.writers = writers;
        this.metacritic = metacritic;
        
    }

}

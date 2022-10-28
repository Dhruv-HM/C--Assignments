// Q2.  Define an interface “Audio” having a method play() and 
// implement it in a class Song with fields “artist” and “title”.
// Define another class PlayList having set of Songs and a 
// method play() which should accept the index of the song to 
// play. If song index is not present should display proper 
// message. 
var Song = /** @class */ (function () {
    function Song(artist, title) {
        this.artist = artist;
        this.title = title;
    }
    Song.prototype.play = function () {
        console.log("You are now playing song }");
    };
    return Song;
}());
var PlayList = /** @class */ (function () {
    function PlayList(songs) {
        this.songs = [];
        this.songs = songs;
    }
    PlayList.prototype.play = function (index) {
        if (index > songs.length) {
            console.log("out of range");
        }
        else {
            this.songs[index].play();
        }
    };
    return PlayList;
}());
var songs = [];
songs.push(new Song("Pink floyd", "Wish you were here"));
songs.push(new Song("is it true", "Tame Imapala"));
songs.push(new Song("Beatles", "Strawberry Fields"));
songs.push(new Song("The Strokes", "Is this it?"));
var pla = new PlayList(songs);
pla.play(1);

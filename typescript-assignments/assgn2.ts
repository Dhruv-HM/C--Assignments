// Q2.  Define an interface “Audio” having a method play() and 
// implement it in a class Song with fields “artist” and “title”.
// Define another class PlayList having set of Songs and a 
// method play() which should accept the index of the song to 
// play. If song index is not present should display proper 
// message. 

interface Audio{
    play(index:number):void;
}

class Song {
    
    artist:string;
    title:string;
    constructor(artist:string,title:string){
        this.artist=artist;
        this.title=title;
    }

    play(): void {
        console.log(`You are now playing song ${this.title}`);
    }
}

class PlayList implements Audio{

    songs:Song[]=[];

    constructor(songs:Song[]){
        this.songs=songs;
    }

    play(index: number): void {
        if(index>songs.length){
            console.log("out of range");
        }
        else{
        this.songs[index].play();
        }
    }

}

var songs:Song[]=[];
songs.push(new Song("Pink floyd","Wish you were here"));
songs.push(new Song("is it true","Tame Imapala"));
songs.push(new Song("Beatles","Strawberry Fields"));
songs.push(new Song("The Strokes","Is this it?"));

var pla=new PlayList(songs);
pla.play(1);


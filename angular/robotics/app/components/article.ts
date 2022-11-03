export class Article {
    title:string;
    author:string;
    category:string;
    postedDate:string;
    likes:number;
    constructor(title:string,author:string,category:string,postedDate:string,likes:number){
        this.author=author;
        this.title=title;
        this.likes=likes;
        this.category=category;
        this.postedDate=postedDate;
    }
}

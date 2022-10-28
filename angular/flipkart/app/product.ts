export class Product {
    name:string;
    desc:string[];
    price:number;
    pic_url:string;
    link:string;
    constructor(name:string,desc:string[],price:number,pic_url:string,link:string){
        this.name=name;
        this.desc=desc;
        this.price=price;
        this.pic_url=pic_url;
        this.link=link;
    }
}

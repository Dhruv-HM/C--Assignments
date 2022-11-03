import { Component, OnInit } from '@angular/core';
import { Article } from '../article';

@Component({
  selector: 'app-article-disp',
  templateUrl: './article-disp.component.html',
  styleUrls: ['./article-disp.component.css']
})
export class ArticleDispComponent implements OnInit {
  article:Article;
  constructor() {
    this.article=new Article("Robotics","Zack Whitakka","Robotics","01/10/2001",890)
   }

  ngOnInit(): void {
  }

}

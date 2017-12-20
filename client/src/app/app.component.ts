import { Component } from '@angular/core';
import { Meta } from '@angular/platform-browser';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private meta: Meta) {
    this.meta.updateTag({ property: 'og:type', content: 'article' });
    this.meta.updateTag({ property: 'og:site_name', content: 'Study4Love' });
    this.meta.updateTag({ property: 'og:title', content: 'LightingTalk-Rendertron' });
    this.meta.updateTag({ property: 'og:description', content: 'A LightingTalk about Rendertron' })    
  }
}

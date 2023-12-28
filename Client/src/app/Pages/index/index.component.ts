import { Component } from '@angular/core';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent {
  movies = [
    { id: 1, title: 'Oppenheimer', imageUrl: 'assets/img/Oppenheimer.jpg' },
    { id: 2, title: 'Guardian of the galaxy', imageUrl: 'assets/img/GOTG.jpg' },
    { id: 3, title: 'Barbie', imageUrl: 'assets/img/Barbie.jpg' },
    // ... andre film ...
  ];

  
}

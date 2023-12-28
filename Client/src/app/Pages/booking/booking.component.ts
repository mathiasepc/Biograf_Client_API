import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent {
  filmId: number = 0;

  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
    // Use safe navigation operator (?) to avoid the "Object is possibly 'null'" error
    this.route.paramMap.subscribe(params => {
      this.filmId = +params.get('filmId')!;
    });
  }
}


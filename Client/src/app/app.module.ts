import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './SharePage/footer/footer.component';
import { NavbarComponent } from './SharePage/navbar/navbar.component';
import { IndexComponent } from './Pages/index/index.component';
import { CommingComponent } from './Pages/comming/comming.component';
import { AboutComponent } from './Pages/about/about.component';
import { BookingComponent } from './Pages/booking/booking.component';
import { CarouselComponent } from './Component/carousel/carousel.component';
import { CalendarComponent } from './Component/calendar/calendar.component';
import { LoginComponent } from './Pages/login/login.component';
import { RegistrererComponent } from './Pages/registrerer/registrerer.component';
import { AdminComponent } from './AdminPages/admin/admin.component';



@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    NavbarComponent,
    IndexComponent,
    CommingComponent,
    AboutComponent,
    BookingComponent,
    CarouselComponent,
    CalendarComponent,
    LoginComponent,
    RegistrererComponent,
    AdminComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

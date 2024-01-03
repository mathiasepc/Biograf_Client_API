import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './Pages/index/index.component';
import { CommingComponent } from './Pages/comming/comming.component';
import { AboutComponent } from './Pages/about/about.component';
import { BookingComponent } from './Pages/booking/booking.component';
import { RegistrererComponent } from './Pages/registrerer/registrerer.component';
import { LoginComponent } from './Pages/login/login.component';

const routes: Routes = [
  { path: '', component:IndexComponent},
  { path: 'aboutUs', component:AboutComponent},
  { path: 'commingSoon', component:CommingComponent},
  { path: 'booking/:filmId', component: BookingComponent },
  { path: 'registers', component:RegistrererComponent },
  { path: 'login', component:LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

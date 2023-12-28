import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './Pages/login-page/login-page.component';
import { RegisterPageComponent } from './Pages/register-page/register-page.component';
import { IndexComponent } from './Pages/index/index.component';
import { CommingComponent } from './Pages/comming/comming.component';
import { AboutComponent } from './Pages/about/about.component';
import { BookingComponent } from './Pages/booking/booking.component';

const routes: Routes = [
  { path: '', component:IndexComponent},
  { path: 'aboutUs', component:AboutComponent},
  { path: 'commingSoon', component:CommingComponent},
  { path: 'login', component:LoginPageComponent},
  { path: 'regristrer', component:RegisterPageComponent},
  { path: 'booking/:filmId', component: BookingComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { Route, RouteReuseStrategy, RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { CreateAccountComponent } from './create-account/create-account.component';
import { AuthGuard } from './auth.guard';
import { LoginGuard } from './login.guard';
import { WeatherComponent } from './weather/weather.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
const route: Route[] = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  {
    path: 'login',
    component: LoginComponent,
    canActivate: [LoginGuard],
  },
  
  { 
    path: 'create',
    component: CreateAccountComponent},
  {
    path: 'forgotpassword',
    component: ForgotPasswordComponent,
  },
  {
    path:'weather',
    component: WeatherComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'dashboard',
    component: DashboardComponent,
    canActivate: [AuthGuard],
  }
]
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    DashboardComponent,
    ForgotPasswordComponent,
    CreateAccountComponent,
    WeatherComponent,

  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(route),
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

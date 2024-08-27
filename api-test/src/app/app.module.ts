import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { AppComponent } from './app.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { Route, Router, RouterModule } from '@angular/router';
import { ApiTestComponent } from './api-test/api-test.component';


const route: Route[] = [
  {
    path: '',
    redirectTo: 'apitest',
    pathMatch: 'full'
  },
  {
    path: 'apitest',
    component: ApiTestComponent,
  },
  

]
@NgModule({
  
  declarations: [
    AppComponent,
    ApiTestComponent,
],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forRoot(route),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

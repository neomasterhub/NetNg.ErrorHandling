import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  statusCode = 200;

  constructor(private readonly http: HttpClient) {
  }

  get() {
    console.log(`Response with code ${this.statusCode} has been requested.`)

    this.http.get<string>(`http://localhost:5120/test?statusCode=${this.statusCode}`)
      .subscribe(console.log);
  }
}

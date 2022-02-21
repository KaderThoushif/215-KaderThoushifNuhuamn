import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {

  }

  data = [
    {src:"assets/Lap1.jpg", name:"lenovo", price:9000},
    {src:"assets/Lap1.jpg", name:"lenovo", price:9000},
    {src:"assets/Lap1.jpg", name:"lenovo", price:9000},
    {src:"assets/Lap1.jpg", name:"lenovo", price:9000},
    {src:"assets/Lap1.jpg", name:"lenovo", price:9000},
    {src:"assets/Lap1.jpg", name:"lenovo", price:9000},
  ]

  
}

import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { MatDividerModule } from '@angular/material/divider';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-decrement-counter',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatIconModule, MatDividerModule],
  templateUrl: './decrement-counter.component.html',
  styleUrl: './decrement-counter.component.scss',
})
export class DecrementCounterComponent {
  public counter: number = 0;

  decrementCounter() {
    this.counter--;
  }
}

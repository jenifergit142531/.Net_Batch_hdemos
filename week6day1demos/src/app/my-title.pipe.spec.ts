import { MyTitlePipe } from './my-title.pipe';

describe('MyTitlePipe', () => {
  it('create an instance', () => {
    const pipe = new MyTitlePipe();
    expect(pipe).toBeTruthy();
  });
});

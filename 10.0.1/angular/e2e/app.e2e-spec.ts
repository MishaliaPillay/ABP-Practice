import { PracticeProjectTemplatePage } from './app.po';

describe('PracticeProject App', function() {
  let page: PracticeProjectTemplatePage;

  beforeEach(() => {
    page = new PracticeProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

// Тест на додавання контакту
describe('Contacts App', () => {
    beforeEach(() => {
      cy.visit('http://localhost:5173');
    });
  
    it('should add a new contact', () => {
      
      cy.get('input[placeholder="Ім\'я"]').type('Ганна');
      cy.get('input[placeholder="Телефон"]').type('0668854495');
      
      cy.contains('Додати').click();
      
      cy.contains('Ганна - 0668854495').should('be.visible');
    });
  });
  
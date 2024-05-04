class StockSpanner:

    def __init__(self):
        self.stack = []
              
        
    def next(self, price: int) -> int:
        stack = self.stack
        
        current_quote, current_span = price, 1
        
        while stack and stack[-1][0] <= current_quote: 
            previous_quote, previous_span = stack.pop()
            current_span += previous_span
        
        stack.append( (current_quote, current_span) )
        
        return current_span

const footwear = require('../footwear');
const { expect } = require('chai');

describe("Footwear Tests", () => {
    describe("generateOrder", () => {
        it("should throw error when orderedShoes is missing", () => {
            const input = { orderedLaces: 'red laces' };
            expect(() => footwear.generateOrder(input)).to.throw('You must order at least one pair of shoes.');
        });

        it("should return correct message when only orderedShoes is provided", () => {
            const input = { orderedShoes: 'running shoes' };
            const result = footwear.generateOrder(input);
            expect(result).to.equal('Your order contains running shoes');
        });

        it("should return correct message when both orderedShoes and orderedLaces are provided", () => {
            const input = { orderedShoes: 'sneakers', orderedLaces: 'white laces' };
            const result = footwear.generateOrder(input);
            expect(result).to.equal('Your order contains sneakers and white laces.');
        });

        it("should throw error when orderedShoes is an empty string", () => {
            const input = { orderedShoes: '' };
            expect(() => footwear.generateOrder(input)).to.throw('You must order at least one pair of shoes.');
        });
    });

    describe("orderStatus", () => {
        it("should apply 10% discount when status is 'New'", () => {
            const amount = 100;
            const status = 'New';
            const result = footwear.orderStatus(amount, status);
            expect(result).to.equal(90);
        });

        it("should return 0 when status is 'New' and amount is 0", () => {
            const amount = 0;
            const status = 'New';
            const result = footwear.orderStatus(amount, status);
            expect(result).to.equal(0);
        });

        it("should return same amount when status is 'Delivery'", () => {
            const amount = 100;
            const status = 'Delivery';
            const result = footwear.orderStatus(amount, status);
            expect(result).to.equal(100);
        });

        it("should return undefined for unknown status", () => {
            const amount = 100;
            const status = 'Other';
            const result = footwear.orderStatus(amount, status);
            expect(result).to.be.undefined;
        });
    });
});
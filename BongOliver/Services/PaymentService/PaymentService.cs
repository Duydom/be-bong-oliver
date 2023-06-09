﻿using BongOliver.DTOs.Response;
using BongOliver.Models;
using BongOliver.Repositories.PaymentRepository;

namespace BongOliver.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public async Task<ResponseDTO> CreatePaymentAsync(Payment payment)
        {
            await _paymentRepository.CreatePaymentAsync(payment);
            await _paymentRepository.IsSaveChange();
            return new ResponseDTO()
            {
                code = 200,
                message = "Success"
            };
        }

        public async Task<ResponseDTO> DeletePayment(int id)
        {
            var payment = await _paymentRepository.PaymentGetPaymentById(id);
            if (payment == null) return new ResponseDTO()
            {
                code = 400,
                message = "Payment with this id does not exist"
            };
            _paymentRepository.DeletePayment(payment);
            await _paymentRepository.IsSaveChange();
            return new ResponseDTO()
            {
                code = 200,
                message = "Success"
            };
        }

        public async Task<ResponseDTO> GetPaymentListAsync()
        {
            var listPayment = await _paymentRepository.GetPaymentListAsync();
            return new ResponseDTO()
            {
                code = 200,
                message = "Success",
                data = listPayment
            };
        }

        public async Task<ResponseDTO> GetPaymentById(int id)
        {
            var payment = await _paymentRepository.PaymentGetPaymentById(id);
            if (payment == null) return new ResponseDTO()
            {
                code = 400,
                message = "Payment with this id does not exist"
            };
            return new ResponseDTO()
            {
                code = 200,
                message = "Success",
                data = payment
            };
        }
    }
}

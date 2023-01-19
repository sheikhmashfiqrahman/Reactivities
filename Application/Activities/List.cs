
// this module is a query handler for the activities. 

using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class List
    {

        public class Query : IRequest<List<Activity>>{}; // pass the query request for the handler

            public class Handler : IRequestHandler<Query, List<Activity>>
            {

                private readonly DataContext _context;

                public Handler(DataContext context )
                {
                    _context=context;
                }

                public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
                {
                    return await _context.Activities.ToListAsync(); // mediator and also looks up the data from the IRequest Database.
                }

            }
    }
}
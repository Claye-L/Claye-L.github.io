module Physics
    type Vec2 = {X:double; Y:double}
    type Kinetics = {
        Position : Vec2;
        Velocity : Vec2;
        Acceleration : Vec2;
    }

    type BoundingBox = (double*double*double*double)

    let addVec2 (a:Vec2) (b:Vec2) = {X = a.X + b.X; Y = a.Y + b.Y}  

    let applyTimeInInertia (kin:Kinetics) =
        {kin with Position = addVec2 kin.Position kin.Velocity; Velocity = addVec2 kin.Velocity kin.Acceleration;}